using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Generator
{
    public partial class GeneratorForm : Form
    {

        public List<VrstaAtributa> VrstaAtributaList = new List<VrstaAtributa>();

        public GeneratorForm()
        {
            InitializeComponent();
            Entitet.clear();
            fillVrstaAtributa();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            Entitet.Name = nameTxt.Text;
            if(Entitet.Name.Length > 0)
            {
                GeneratorJSKlasa.generate();
                GeneratorMigrations.generate();
                GeneratorModelaPhp.generate();
                GeneratorController.generate();
            }
            else
            {
                MessageBox.Show("Unesi ime (prvo veliko početno!");
            }
           
        }

        private void GeneratorForm_Load(object sender, EventArgs e)
        {
            entityGridView.DataSource = Entitet.AtributList;
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            AtributForm form = new AtributForm(VrstaAtributaList);
            form.ShowDialog();
            RefreshGrid();
        }

        public void fillVrstaAtributa()
        {
            VrstaAtributaList.Clear();
            VrstaAtributaList.Add(new VrstaAtributa("string"));
            VrstaAtributaList.Add(new VrstaAtributa("array"));
            VrstaAtributaList.Add(new VrstaAtributa("boolean"));
            VrstaAtributaList.Add(new VrstaAtributa("integer"));
            VrstaAtributaList.Add(new VrstaAtributa("text"));
            VrstaAtributaList.Add(new VrstaAtributa("date"));
            VrstaAtributaList.Add(new VrstaAtributa("dateTime"));
            VrstaAtributaList.Add(new VrstaAtributa("foreign"));
        }



        private void deleteAtributeBtn_Click(object sender, EventArgs e)
        {
            if(entityGridView.RowCount != 0)
            {
                Atribut selected = entityGridView.CurrentRow.DataBoundItem as Atribut;
                Entitet.AtributList.Remove(selected);
            }
            RefreshGrid();
           
        }

        private void RefreshGrid()
        {
            entityGridView.DataSource = Entitet.AtributList.ToList();
        }

        private void entityGridView_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Atribut selected = entityGridView.CurrentRow.DataBoundItem as Atribut;
            AtributForm form = new AtributForm(VrstaAtributaList, selected);
            form.ShowDialog();
            RefreshGrid();
        }

        private void clearAllBtn_Click(object sender, EventArgs e)
        {
            Entitet.clear();
            RefreshGrid();
        }
    }
}
