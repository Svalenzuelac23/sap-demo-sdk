using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SAPbobsCOM;

namespace Sesion_2_Sdk_SAP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_connect_Click(object sender, EventArgs e)
        {
            ConnectSap();
        }


        private Company ConnectSap()
        {
            var oCompany = new Company
            {
                LicenseServer = "",
                Server = "",
                DbServerType = ,
                CompanyDB = "",
                UserName = "",
                Password = "",
                language = 
            };

            if (oCompany.Connect() != 0)
            {
                oCompany.GetLastError(out int errorCode, out string errorMessage);
                lbl_message.Text = $"Conexion fallida {errorCode} - {errorMessage}";
            }
            else
            {
                lbl_message.Text = "Conectado exitosamente";
            }

            return oCompany;

        }

        private void btn_addOrder_Click(object sender, EventArgs e)
        {
            string docEntryOrden;

            var oCompany = ConnectSap();
            var oOrder = (IDocuments)oCompany.GetBusinessObject(BoObjectTypes.oOrders);

            oOrder.CardCode = "C03842";
            oOrder.DocDate = DateTime.Now;
            oOrder.DocDueDate = DateTime.Now;
            oOrder.Comments = "Orden agregada via SDK";
            oOrder.UserFields.Fields.Item("U_Route").Value = "10000";

            oOrder.Lines.ItemCode = "DRY12565";
            oOrder.Lines.Quantity = 1;
            //oOrder.Lines.UnitPrice = 1.5;

            oOrder.Lines.Add();

            oOrder.Lines.ItemCode = "DRY003511";
            oOrder.Lines.Quantity = 2;
            //oOrder.Lines.UnitPrice = 0.75;


            if (oOrder.Add() != 0)
            {
                oCompany.GetLastError(out int errorCode, out string errorMessage);
                lbl_message.Text = $"Agregar orden fallido {errorCode} - {errorMessage}";
            }
            else
            {
                oCompany.GetNewObjectCode(out docEntryOrden);
                lbl_message.Text = $"Orden Creada exitosamente numero {docEntryOrden}";
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {

            string docEntryInvoice;

            var oCompany = ConnectSap();
            var oInvoice = (IDocuments)oCompany.GetBusinessObject(BoObjectTypes.oInvoices);


            oInvoice.CardCode = "C03842";
            oInvoice.DocDate = DateTime.Now;
            oInvoice.DocDueDate = DateTime.Now;
            oInvoice.Comments = "Invoice agregada via SDK";


            oInvoice.Lines.ItemCode = "DRY12565";
            oInvoice.Lines.Quantity = 1;
            oInvoice.Lines.BaseEntry = 127390;
            oInvoice.Lines.BaseLine = 0;
            oInvoice.Lines.BaseType = (int)BoObjectTypes.oOrders;

            oInvoice.Lines.Add();

            oInvoice.Lines.ItemCode = "DRY003511";
            oInvoice.Lines.Quantity = 2;
            oInvoice.Lines.BaseEntry = 127390;
            oInvoice.Lines.BaseLine = 1;
            oInvoice.Lines.BaseType = (int)BoObjectTypes.oOrders;


            if (oInvoice.Add() != 0)
            {
                oCompany.GetLastError(out int errorCode, out string errorMessage);
                lbl_message.Text = $"Agregar factura fallido {errorCode} - {errorMessage}";
            }
            else
            {
                oCompany.GetNewObjectCode(out docEntryInvoice);
                lbl_message.Text = $"Facrtura Creada exitosamente numero {docEntryInvoice}";
            }



        }

        private void txt_duration_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            var oCompany = ConnectSap();

            oCompany.StartTransaction();

            var oUserTable = (UserTable)oCompany.UserTables.Item("CURSOS");

            var guid = Guid.NewGuid();
            oUserTable.Code = guid.ToString();
            oUserTable.Name = guid.ToString();

            oUserTable.UserFields.Fields.Item("U_Nombre").Value = txt_name.Text;
            oUserTable.UserFields.Fields.Item("U_Duracion").Value = txt_duration.Text;
            oUserTable.UserFields.Fields.Item("U_Estado").Value = txt_state.Text;

            if (oUserTable.Add() == 0)
            {
                oCompany.EndTransaction(BoWfTransOpt.wf_Commit);
                return;
            }

            oCompany.GetLastError(out int errorCode, out string errorMessage);
            oCompany.EndTransaction(BoWfTransOpt.wf_RollBack);


        }

        private void button2_Click(object sender, EventArgs e)
        {
            var oCompany = ConnectSap();
            var oUserTable = (UserTable)oCompany.UserTables.Item("CURSOS");

            string key = txt_id.Text;
            if (!oUserTable.GetByKey(key)) return;

            oUserTable.UserFields.Fields.Item("U_Nombre").Value = txt_name.Text;
            oUserTable.UserFields.Fields.Item("U_Duracion").Value = txt_duration.Text;
            oUserTable.UserFields.Fields.Item("U_Estado").Value = txt_state.Text;

            if (oUserTable.Update() == 0) return;

            oCompany.GetLastError(out int errorCode, out string errorMessage);

        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            var oCompany = ConnectSap();
            var oUserTable = (UserTable)oCompany.UserTables.Item("CURSOS");

            string key = txt_id.Text;
            if (!oUserTable.GetByKey(key)) return;

            if (oUserTable.Remove() == 0) return;

            oCompany.GetLastError(out int errorCode, out string errorMessage);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            var oCompany = ConnectSap();
            var oRecordSet =(Recordset) oCompany.GetBusinessObject(BoObjectTypes.BoRecordset);

            const string QUERY = "SELECT * FROM [@CURSOS] T00";
            var courses = new List<Curso>();

            oRecordSet.DoQuery(QUERY);

            while (!oRecordSet.EoF)
            {
                courses.Add(new Curso()
                {
                    Duracion =oRecordSet.Fields.Item("U_Duracion").Value.ToString(),
                    Code = oRecordSet.Fields.Item("Code").Value.ToString(),
                    Estado = oRecordSet.Fields.Item("U_Estado").Value.ToString(),
                    Name = oRecordSet.Fields.Item("Name").Value.ToString(),
                    Nombre = oRecordSet.Fields.Item("U_Nombre").Value.ToString(),
                });

                oRecordSet.MoveNext();
            }

            dgv_courses.DataSource = courses;
        }
    }
}
