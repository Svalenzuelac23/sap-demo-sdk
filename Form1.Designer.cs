
namespace Sesion_2_Sdk_SAP
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_connect = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_message = new System.Windows.Forms.Label();
            this.btn_addOrder = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_delete = new System.Windows.Forms.Button();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.txt_state = new System.Windows.Forms.TextBox();
            this.txt_duration = new System.Windows.Forms.TextBox();
            this.btn_save = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.btn_read = new System.Windows.Forms.Button();
            this.dgv_courses = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_courses)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_connect
            // 
            this.btn_connect.Location = new System.Drawing.Point(12, 12);
            this.btn_connect.Name = "btn_connect";
            this.btn_connect.Size = new System.Drawing.Size(72, 36);
            this.btn_connect.TabIndex = 0;
            this.btn_connect.Text = "Connect";
            this.btn_connect.UseVisualStyleBackColor = true;
            this.btn_connect.Click += new System.EventHandler(this.btn_connect_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(99, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mensaje";
            // 
            // lbl_message
            // 
            this.lbl_message.AutoSize = true;
            this.lbl_message.Location = new System.Drawing.Point(99, 32);
            this.lbl_message.Name = "lbl_message";
            this.lbl_message.Size = new System.Drawing.Size(16, 15);
            this.lbl_message.TabIndex = 2;
            this.lbl_message.Text = "...";
            // 
            // btn_addOrder
            // 
            this.btn_addOrder.Location = new System.Drawing.Point(12, 79);
            this.btn_addOrder.Name = "btn_addOrder";
            this.btn_addOrder.Size = new System.Drawing.Size(127, 36);
            this.btn_addOrder.TabIndex = 3;
            this.btn_addOrder.Text = "Add Order";
            this.btn_addOrder.UseVisualStyleBackColor = true;
            this.btn_addOrder.Click += new System.EventHandler(this.btn_addOrder_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 121);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(127, 36);
            this.button1.TabIndex = 4;
            this.button1.Text = "Copy To Invoice";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_read);
            this.panel1.Controls.Add(this.btn_delete);
            this.panel1.Controls.Add(this.txt_id);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.txt_state);
            this.panel1.Controls.Add(this.txt_duration);
            this.panel1.Controls.Add(this.btn_save);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txt_name);
            this.panel1.Location = new System.Drawing.Point(293, 191);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(657, 309);
            this.panel1.TabIndex = 5;
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(328, 249);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(119, 41);
            this.btn_delete.TabIndex = 9;
            this.btn_delete.Text = "Eliminar";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // txt_id
            // 
            this.txt_id.Location = new System.Drawing.Point(137, 181);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(480, 23);
            this.txt_id.TabIndex = 8;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(183, 249);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(119, 41);
            this.button2.TabIndex = 7;
            this.button2.Text = "Actualizar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txt_state
            // 
            this.txt_state.Location = new System.Drawing.Point(137, 130);
            this.txt_state.Name = "txt_state";
            this.txt_state.Size = new System.Drawing.Size(480, 23);
            this.txt_state.TabIndex = 6;
            // 
            // txt_duration
            // 
            this.txt_duration.Location = new System.Drawing.Point(137, 85);
            this.txt_duration.Name = "txt_duration";
            this.txt_duration.Size = new System.Drawing.Size(480, 23);
            this.txt_duration.TabIndex = 5;
            this.txt_duration.TextChanged += new System.EventHandler(this.txt_duration_TextChanged);
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(32, 249);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(119, 41);
            this.btn_save.TabIndex = 4;
            this.btn_save.Text = "Guardar";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Estado";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Duracion";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre del Curso";
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(137, 31);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(480, 23);
            this.txt_name.TabIndex = 0;
            // 
            // btn_read
            // 
            this.btn_read.Location = new System.Drawing.Point(476, 249);
            this.btn_read.Name = "btn_read";
            this.btn_read.Size = new System.Drawing.Size(119, 41);
            this.btn_read.TabIndex = 10;
            this.btn_read.Text = "Lectura";
            this.btn_read.UseVisualStyleBackColor = true;
            this.btn_read.Click += new System.EventHandler(this.button3_Click);
            // 
            // dgv_courses
            // 
            this.dgv_courses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_courses.Location = new System.Drawing.Point(293, 12);
            this.dgv_courses.Name = "dgv_courses";
            this.dgv_courses.RowTemplate.Height = 25;
            this.dgv_courses.Size = new System.Drawing.Size(484, 150);
            this.dgv_courses.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(995, 512);
            this.Controls.Add(this.dgv_courses);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_addOrder);
            this.Controls.Add(this.lbl_message);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_connect);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_courses)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_connect;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_message;
        private System.Windows.Forms.Button btn_addOrder;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txt_state;
        private System.Windows.Forms.TextBox txt_duration;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_read;
        private System.Windows.Forms.DataGridView dgv_courses;
    }
}

