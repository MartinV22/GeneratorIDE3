using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Generator
{
    public partial class AtributForm : Form
    {
        public List<VrstaAtributa> vrstaAtributaList;
        public Atribut atribut = new Atribut();
        public bool isEdit = false;

        public AtributForm(List<VrstaAtributa> vrstaAtributaList)
        {
            InitializeComponent();
            this.isEdit = false;
            this.vrstaAtributaList = vrstaAtributaList;
        }
        public AtributForm(List<VrstaAtributa> vrstaAtributaList, Atribut atribut)
        {
            InitializeComponent();
            this.vrstaAtributaList = vrstaAtributaList;
            this.atribut = atribut;
            this.isEdit = true;
        }

        private void AtributForm_Load(object sender, EventArgs e)
        {
            vrstaCmbx.DataSource = vrstaAtributaList;
            defaultValueTxt.Enabled = false;
            if(isEdit)
            {
                nameTxt.Text = atribut.Name;
                referencaTxt.Text = atribut.Reference;
                nullableChbx.Checked = atribut.Nullable;
                vrstaCmbx.SelectedIndex = vrstaCmbx.FindString(atribut.Type.Name);
                defaultChbx.Checked = atribut.HasDefault;
                defaultValueTxt.Text = atribut.DefaultValue;
            }
            
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void vrstaCmbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedValue = vrstaCmbx.SelectedValue.ToString();
            if (selectedValue != "foreign")
            {
                this.referencaTxt.Text = "";
                this.referencaTxt.Enabled = false;
            }
            else
            {
                this.referencaTxt.Enabled=true;
            }
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            bool allGood = checkAll();
            if (allGood)
            {
                if (isEdit)
                {
                    string selectedValue = vrstaCmbx.SelectedValue.ToString();
                    int selectedIndex = vrstaCmbx.SelectedIndex;
                   
                    if (selectedValue == "foreign")
                    {
                        atribut.Reference = referencaTxt.Text;
                    }
                    else
                    {
                        atribut.Reference = null;
                    }
                    var result = from r in Entitet.AtributList where r.Name == atribut.Name & r.Reference == atribut.Reference select r;
                    result.First().Name = nameTxt.Text;
                    result.First().Reference = referencaTxt.Text;
                    result.First().Type = vrstaAtributaList[selectedIndex];
                    result.First().Nullable = nullableChbx.Checked;
                    result.First().HasDefault = defaultChbx.Checked;
                    result.First().DefaultValue = defaultValueTxt.Text;
                    Close();
                }
                else
                {
                    string selectedValue = vrstaCmbx.SelectedValue.ToString();
                    int selectedIndex = vrstaCmbx.SelectedIndex;
                    atribut.Name = nameTxt.Text;
                    atribut.Type = vrstaAtributaList[selectedIndex];
                    atribut.Nullable = nullableChbx.Checked;
                    atribut.HasDefault = defaultChbx.Checked;
                    atribut.DefaultValue = defaultValueTxt.Text;

                    if (selectedValue == "foreign")
                    {
                        atribut.Reference = referencaTxt.Text;
                    }
                    else
                    {
                        atribut.Reference = null;
                    }
                    Entitet.AtributList.Add(atribut);
                    this.Close();
                }
                
            }
        }

        private bool checkAll()
        {
            string selectedValue = vrstaCmbx.SelectedValue.ToString();
            if (nameTxt.Text == null || nameTxt.Text == string.Empty)
            {
                MessageBox.Show("Unesite naziv atributa");
                return false;
            }

            if (selectedValue == "foreign")
            {
                if (referencaTxt.Text == "" || referencaTxt.Text == null)
                {
                    MessageBox.Show("Unesi naziv tablice za referencu");
                    return false;
                }
            }
            return true;
        }

        private void defaultChbx_CheckedChanged(object sender, EventArgs e)
        {
            if (defaultChbx.Checked == false)
            {
                this.defaultValueTxt.Text = "";
                this.defaultValueTxt.Enabled = false;
            }
            else
            {
                this.defaultValueTxt.Enabled = true;
            }
        }
    }
}
