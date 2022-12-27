using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using System.Data.Entity.Migrations;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.WebRequestMethods;

namespace SoftExpressWinFO
{
    public partial class Form1 : Form
    {
        TestEntities _context = new TestEntities();


        public Form1()
        {
            InitializeComponent();

            // Set the FormBorderStyle property to None
            this.FormBorderStyle = FormBorderStyle.None;

            // Add a custom close button to the form
            Button closeButton = new Button();
            closeButton.Text = "X";
            closeButton.DialogResult = DialogResult.Cancel;
            closeButton.Location = new Point(this.Width - 30, 0);
            closeButton.Size = new Size(30, 30);
            closeButton.Click += new EventHandler(closeButton_Click);
            this.Controls.Add(closeButton);
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing && this.DialogResult == DialogResult.Cancel)
            {
                e.Cancel = true;
                this.Hide();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {


        }

        private void btnTeDhenat_Click(object sender, EventArgs e)
        {
            loadData();
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            DataGridViewRow row = dataGridView1.Rows[rowIndex];

            if (e.ColumnIndex == 0 && e.RowIndex >= 0)
            {
                // Get information of row when "Edit" button is clicked
                int   featureId = Convert.ToInt32(row.Cells["Id"].Value);

               
                txtEmertimi.Text = (row.Cells["Emertimi"].Value).ToString();
                dtSkadenc.Text = (row.Cells["DatasKdences"].Value).ToString();
                txtNjesia.Text = (row.Cells["Njesia"].Value).ToString();
                txtCmimi.Text = (row.Cells["Cmimi"].Value).ToString();
                string lloji = (row.Cells["Lloji"].Value).ToString();
                if (lloji == "Vendi")
                {
                    rdlloji2.Checked = true;
                    rbLloji.Checked = false;
                }
                else
                {
                    rdlloji2.Checked = false;
                    rbLloji.Checked = true;
                }
                if (Convert.ToInt32(row.Cells["KaTvsh"].Value)==1){
                    cbKaTVSH.Checked = true;
                }
                else
                {
                    cbKaTVSH.Checked = false;
                }

                cbTipi.Text = (row.Cells["Tipi"].Value).ToString() ;
                txtBarkodi.Text = (row.Cells["Barkod"].Value).ToString();


                // Do something with the row information
            }
            else if (e.ColumnIndex == 1 && e.RowIndex >= 0)
            {
                int id = Convert.ToInt32(row.Cells["Id"].Value);
                DialogResult result = MessageBox.Show("Konfirmo  Fshirjen!", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if(result == DialogResult.Yes)
                {
                    Fature ft1= new Fature();

                    DeleteFature(id);
                    MessageBox.Show("U fshi me sukses!");
                    loadData();

                }
            }
        }
        private void btnRuaj_Click(object sender, EventArgs e)
        {
            Fature ft1 = new Fature();
            ft1.Emertimi = txtEmertimi.Text;
            ft1.Njesia = txtNjesia.Text;
            ft1.Cmimi = Convert.ToInt32(txtCmimi.Text.Trim());
            ft1.DatasKdences = DateTime.Parse(dtSkadenc.Text.Trim());
            if (rbLloji.Checked)
            {
                ft1.Lloji = "Importuar";
            }
            else if (rdlloji2.Checked)
            {
                ft1.Lloji = "Vendi";
            }
            if (cbKaTVSH.Checked)
            {
                ft1.KaTvsh = true;

            }
            else
            {
                ft1.KaTvsh = false;
            }
            ft1.Tipi=cbTipi.Text;
            ft1.Barkod=txtBarkodi.Text;
            _context.Fatures.Add(ft1);
            _context.SaveChanges();
            MessageBox.Show("Regjistrimi u krye me sukses ! ");
            ClearForm();
        }

        private void btnKerko_Click(object sender, EventArgs e)
        {
            Kerko(txtEmertimi.Text, txtBarkodi.Text);

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Fature fatureNew = _context.Fatures.First(x => x.Id == id);
            fatureNew.Emertimi = txtEmertimi.Text;
            fatureNew.Njesia = txtNjesia.Text;
            fatureNew.DatasKdences = DateTime.Parse(dtSkadenc.Text.Trim());
            if (rbLloji.Checked)
            {
                fatureNew.Lloji = "Importuar";
            }
            else if (rdlloji2.Checked)
            {
                fatureNew.Lloji = "Vendi";
            }
            if (cbKaTVSH.Checked)
            {
                fatureNew.KaTvsh = true;

            }
            else
            {
                fatureNew.KaTvsh = false;
            }
            fatureNew.Tipi = cbTipi.Text;
            fatureNew.Barkod = txtBarkodi.Text;

            _context.SaveChanges();
        }

        //Methods
        
        private void Kerko(string emertimi,  string  barkodi)
        {
            if (emertimi != null)
            {
                var fature1 = _context.Fatures.FirstOrDefault(x => x.Emertimi == txtEmertimi.Text);
                txtEmertimi.Text = fature1.Emertimi;
                txtNjesia.Text = fature1.Njesia;
                txtCmimi.Text = fature1.Cmimi.ToString();
                dtSkadenc.Text = fature1.DatasKdences.ToString();
                if (fature1.Lloji == "Vendi")
                {
                    rdlloji2.Checked = true;
                    rbLloji.Checked = false;
                }
                else
                {
                    rdlloji2.Checked = false;
                    rbLloji.Checked = true;
                }
                if (fature1.KaTvsh == true)
                {
                    cbKaTVSH.Checked = true;

                }
                else
                {
                    cbKaTVSH.Checked = false;
                }
                cbTipi.Text = fature1.Tipi;
                txtBarkodi.Text = fature1.Barkod;
            }
            else
            {
                MessageBox.Show("Fatura nuk u gjet ! ");
            }
        }
        private  void loadData()
        {
            dataGridView1.DataSource = _context.Fatures.ToList();

            if (dataGridView1.Columns["Edit"] == null)
            {
                // Add the Edit button column to the DataGridView
                DataGridViewButtonColumn editButtonColumn = new DataGridViewButtonColumn();
                editButtonColumn.HeaderText = "Edit";
                editButtonColumn.Text = "Edit";
                editButtonColumn.Name = "Edit";
                editButtonColumn.UseColumnTextForButtonValue = true;
                dataGridView1.Columns.Insert(0, editButtonColumn);
            }

            // Check if the Delete button column already exists in the DataGridView
            if (dataGridView1.Columns["Delete"] == null)
            {
                // Add the Delete button column to the DataGridView
                DataGridViewButtonColumn deleteButtonColumn = new DataGridViewButtonColumn();
                deleteButtonColumn.Text = "Delete";
                deleteButtonColumn.HeaderText = "Delete";
                deleteButtonColumn.Name = "Delete";
                deleteButtonColumn.UseColumnTextForButtonValue = true;
                dataGridView1.Columns.Insert(1, deleteButtonColumn);
            }

        }
        private void DeleteFature(int id)
        {
            var cusDel=  (from y in _context.Fatures
                         where y.Id == id
                         select y).FirstOrDefault();
            if (cusDel!= null)
            {
                _context.Fatures.Remove(cusDel);
                _context.SaveChanges();

            }

        }
        private void ClearForm()
        {
            txtEmertimi.Text = "";
            txtNjesia.Text = "";
            txtCmimi.Text = "";
            dtSkadenc.Text = "";
            rbLloji.Checked = false;
            rdlloji2.Checked = false;
            cbKaTVSH.Checked = false;
            cbTipi.Text = "";
            txtBarkodi.Text = "";
        }

       
    }
}