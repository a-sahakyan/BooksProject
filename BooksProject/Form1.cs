using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace BooksProject
{
    partial class Books : Form
    {
      
        

        public Books()
        {
            InitializeComponent();
        }

        private void AddButton(object sender, EventArgs e)
        {
            try
            {
                DataTable dataTable = (DataTable)bookDataGridView.DataSource;
                DataRow drToAdd = dataTable.NewRow();
                drToAdd["author"] = authorBox.Text;
                drToAdd["title"] = titleBox.Text;
                drToAdd["genre"] = genreBox.Text;
                drToAdd["price"] = priceBox.Text;
                drToAdd["publish_date"] = publishDateBox.Text;
                drToAdd["description"] = descriptionBox.Text;
                drToAdd["id"] = idBox.Text;
                authorBox.Clear();
                titleBox.Clear();
                genreBox.Clear();
                priceBox.Clear();
                publishDateBox.Clear();
                descriptionBox.Clear();
                idBox.Clear();
                dataTable.Rows.Add(drToAdd);
                dataTable.AcceptChanges();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
            
        }

        private void LoadButton(object sender, EventArgs e)
        {
            try
            {
                DataSet dataSet = new DataSet();
                dataSet.ReadXml(@"Resources\Books.xml");
                bookDataGridView.DataSource = dataSet.Tables[0];
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
            


        }
       

        private void SaveButton(object sender, EventArgs e)
        {
            try
            {
                
                DataTable dt = new DataTable();
                for (int i = 1; i < bookDataGridView.Columns.Count + 1; i++)
                {
                    DataColumn column = new DataColumn(bookDataGridView.Columns[i - 1].HeaderText);
                    dt.Columns.Add(column);
                }
                int columnCount = bookDataGridView.Columns.Count;
                foreach (DataGridViewRow dr in bookDataGridView.Rows)
                {
                    DataRow dataRow = dt.NewRow();
                    for (int i = 0; i < columnCount; i++)
                    {                        
                        dataRow[i] = dr.Cells[i].Value;
                    }
                    dt.Rows.Add(dataRow);
                }

                DataSet ds = new DataSet();
                ds.Tables.Add(dt);
                XmlTextWriter xmlSave = new XmlTextWriter(@"Resources/SerializationOverview.xml", Encoding.UTF8);

                ds.WriteXml(xmlSave);
                xmlSave.Close();
            


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
          
            }

        

        private void DeleteButton(object sender, EventArgs e)
        {
            try
            {
                bookDataGridView.Rows.Remove(bookDataGridView.CurrentRow);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
           
        }

        private void EditButton(object sender, EventArgs e)
        {
            try
            {
                authorBox.Text = bookDataGridView.CurrentRow.Cells[0].Value.ToString();
                titleBox.Text = bookDataGridView.CurrentRow.Cells[1].Value.ToString();
                genreBox.Text = bookDataGridView.CurrentRow.Cells[2].Value.ToString();
                priceBox.Text = bookDataGridView.CurrentRow.Cells[3].Value.ToString();
                publishDateBox.Text = bookDataGridView.CurrentRow.Cells[4].Value.ToString();
                descriptionBox.Text = bookDataGridView.CurrentRow.Cells[5].Value.ToString();
                idBox.Text = bookDataGridView.CurrentRow.Cells[6].Value.ToString();




                bookDataGridView.Rows.Remove(bookDataGridView.CurrentRow);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
           
        }

        

       
    }
}
