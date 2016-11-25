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
    public partial class ucEditProvider : UserControl
    {
        #region "Constructor"
            public ucEditProvider()
        {
            InitializeComponent();
        }
        #endregion

        #region "Eventos"
            private void btnBack_Click(object sender, EventArgs e)
            {
                try
                {
                    Cursor.Current = Cursors.WaitCursor;
                    UserControl content = new ucListProvider();
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

            private void btnEdit_Click(object sender, EventArgs e)
            {
                try
                {
                    Cursor.Current = Cursors.WaitCursor;

                    Global.common.updateProviderSQL(Global.idProvider, tbName.Text, tbAddress.Text, tbPhone.Text);

                    Cursor.Current = Cursors.Default;

                    MessageBox.Show("Proveedor modificado correctamente", "Charlotte", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    UserControl content = new ucListProvider();
                    Global.mainForm.pContent.Controls.Clear();
                    Global.mainForm.pContent.Controls.Add(content);
                }
                catch (Exception ex)
                {
                    Mail.gestionaError(ex.Message);Global.error = true;
                    MessageBox.Show("ERROR", "Charlotte", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            private void ucEditProvider_Load(object sender, EventArgs e)
            {
                try
                {
                    Cursor.Current = Cursors.WaitCursor;

                    DataTable prov = Global.common.getProviderSQL(Global.idProvider);

                    tbAddress.Text = prov.Rows[0]["DIRECCION"].ToString();
                    tbName.Text = prov.Rows[0]["NOMBRE"].ToString();
                    tbPhone.Text = prov.Rows[0]["TELEFONO"].ToString();

                    Cursor.Current = Cursors.Default;
                }
                catch (Exception ex)
                {
                    Mail.gestionaError(ex.Message);Global.error = true;
                    MessageBox.Show("ERROR", "Charlotte", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        #endregion
    }
}
