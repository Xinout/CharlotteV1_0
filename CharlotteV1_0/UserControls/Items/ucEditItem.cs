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
    public partial class ucEditItem : UserControl
    {
        #region "Constructor"
            public ucEditItem()
            {
                InitializeComponent();
            }
        #endregion

        #region "Eventos"
            private void btnEdit_Click(object sender, EventArgs e)
            {
                try
                {
                    Cursor.Current = Cursors.WaitCursor;

                    double dPVP = 0;
                    int dCantidad = 0;

                    double.TryParse(tbPVP.Text, out dPVP);
                    int.TryParse(tbCantidad.Text, out dCantidad);

                    if (dPVP <= 0)
                    {
                        MessageBox.Show("El PVP debe ser mayor que cero", "Charlotte", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else if (dCantidad < 0)
                    {
                        MessageBox.Show("La cantidad debe ser cero o mayor", "Charlotte", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        Global.common.updateItemSQL(Global.idItem, tbRef.Text, tbDesc.Text, dPVP, dCantidad);

                        Cursor.Current = Cursors.Default;

                        MessageBox.Show("Articulo modificado correctamente", "Charlotte", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        UserControl content = new ucListItem();
                        Global.mainForm.pContent.Controls.Clear();
                        Global.mainForm.pContent.Controls.Add(content);
                    }


                }
                catch (Exception ex)
                {
                    Mail.gestionaError(ex.Message);Global.error = true;
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
                    Mail.gestionaError(ex.Message);Global.error = true;
                    MessageBox.Show("ERROR", "Charlotte", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            private void ucEditItem_Load(object sender, EventArgs e)
            {
                try
                {
                    Cursor.Current = Cursors.WaitCursor;

                    DataTable prov = Global.common.getItemSQL(Global.idItem);

                    tbRef.Text = prov.Rows[0]["REFERENCIA"].ToString();
                    tbDesc.Text = prov.Rows[0]["DESCRIPCION"].ToString();
                    tbPVP.Text = prov.Rows[0]["PVP"].ToString();
                    tbCantidad.Text = prov.Rows[0]["DISPONIBLE"].ToString();

                    Cursor.Current = Cursors.Default;
                }
                catch (Exception ex)
                {
                    Mail.gestionaError(ex.Message);Global.error = true;
                    MessageBox.Show("ERROR", "Charlotte", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        #endregion

        #region "Métodos Privados"

        #endregion
    }
}
