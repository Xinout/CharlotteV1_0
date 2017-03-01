using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Utils;

namespace CharlotteV1_0
{
    public partial class ucAddItem : UserControl
    {
        public ucAddItem()
        {
            InitializeComponent();
            loadCombo();
        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            try
            {
                string texto = validate();
                long idItemInserted = 0;

                if (string.IsNullOrEmpty(texto))
                {
                    int idProv = 0;
                    int.TryParse(cbProv.SelectedValue.ToString(), out idProv);

                    idItemInserted = Global.common.insertItemSQL(tbRef.Text.Trim().ToUpper(),0, tbDescription.Text.ToUpper(),  Math.Round(Convert.ToDouble(tbPVP.Text),2), Convert.ToInt32(tbQuant.Text),idProv);

                    if (idItemInserted > 0)
                    {
                        MessageBox.Show("El artículo se ha guardado correctamente", "Charlotte", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        UserControl content = new ucListItem();
                        Global.mainForm.pContent.Controls.Clear();
                        Global.mainForm.pContent.Controls.Add(content);
                    }
                    else
                    {
                        MessageBox.Show("Error al guardar el artículo, no se ha podido guardar correctamente", "Charlotte", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show(texto, "Charlotte", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                Mail.gestionaError(ex.Message); Global.error = true;
                MessageBox.Show("ERROR", "Charlotte", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string validate()
        {
            try
            {
                double aux = 0;
                int auxNum = 0;
                string strMessage = string.Empty;

                if (cbProv.SelectedValue == null)
                {
                    strMessage += "- Debe rellenar el proveedor\n";
                }

                if (string.IsNullOrEmpty(tbCostUnit.Text))
                {
                    strMessage += "- Debe rellenar el coste\n";
                }
                else
                {
                    double.TryParse(tbCostUnit.Text.Replace(".", ","), out aux);

                    if (aux <= 0)
                    {
                        strMessage += "- El coste no tiene el formato correcto\n";
                    }
                }

                if (string.IsNullOrEmpty(tbDescription.Text))
                {
                    strMessage += "- Debe rellenar la descripción\n";
                }

                if (string.IsNullOrEmpty(tbRef.Text))
                {
                    strMessage += "- Debe rellenar el nombre\n";
                }

                if (string.IsNullOrEmpty(tbPVP.Text))
                {
                    strMessage += "- Debe rellenar el PVP\n";
                }
                else
                {
                    double.TryParse(tbPVP.Text.Replace(".", ","), out aux);

                    if (aux <= 0)
                    {
                        strMessage += "- El PVP no tiene el formato correcto\n";
                    }
                }

                if (string.IsNullOrEmpty(tbQuant.Text))
                {
                    strMessage += "- Debe rellenar la cantidad\n";
                }
                else
                {
                    int.TryParse(tbQuant.Text, out auxNum);

                    if (aux <= 0)
                    {
                        strMessage += "- La cantidad no tiene el formato correcto\n";
                    }
                }

                return strMessage;
            }
            catch (Exception ex)
            {
                Mail.gestionaError(ex.Message); Global.error = true;
                MessageBox.Show("ERROR", "Charlotte", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return "ERROR";
            }
        }

        private void loadCombo()
        {
            try
            {
                DataTable listaProveedores = Global.common.getAllProviderSQL();

                if ((listaProveedores != null) && (listaProveedores.Rows.Count > 0))
                {
                    cbProv.DataSource = listaProveedores.DefaultView;
                    cbProv.DisplayMember = "NOMBRE";
                    cbProv.ValueMember = "ID";
                }
            }
            catch (Exception ex)
            {
                Mail.gestionaError(ex.Message); Global.error = true;
                MessageBox.Show("ERROR", "Charlotte", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                UserControl content = new ucListItem();
                Global.mainForm.pContent.Controls.Clear();
                Global.mainForm.pContent.Controls.Add(content);
                Cursor.Current = Cursors.Default;
            }
            catch (Exception ex)
            {
                Mail.gestionaError(ex.Message); Global.error = true;
                MessageBox.Show("ERROR", "Charlotte", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
