
namespace CRUDCaptura
{
    partial class VerDatos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.MenuInfo = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.boxtext = new System.Windows.Forms.GroupBox();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.ApeidoMaterno = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.boxtext.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.MenuInfo);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.panel1);
            this.splitContainer1.Size = new System.Drawing.Size(488, 167);
            this.splitContainer1.SplitterDistance = 25;
            this.splitContainer1.TabIndex = 0;
            // 
            // MenuInfo
            // 
            this.MenuInfo.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.MenuInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MenuInfo.Location = new System.Drawing.Point(0, 0);
            this.MenuInfo.Name = "MenuInfo";
            this.MenuInfo.Size = new System.Drawing.Size(488, 25);
            this.MenuInfo.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.boxtext);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(488, 138);
            this.panel1.TabIndex = 0;
            // 
            // boxtext
            // 
            this.boxtext.Controls.Add(this.ApeidoMaterno);
            this.boxtext.Controls.Add(this.txtBuscar);
            this.boxtext.Dock = System.Windows.Forms.DockStyle.Fill;
            this.boxtext.Location = new System.Drawing.Point(0, 0);
            this.boxtext.Name = "boxtext";
            this.boxtext.Size = new System.Drawing.Size(488, 138);
            this.boxtext.TabIndex = 2;
            this.boxtext.TabStop = false;
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(12, 35);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(264, 20);
            this.txtBuscar.TabIndex = 0;
            // 
            // ApeidoMaterno
            // 
            this.ApeidoMaterno.AutoSize = true;
            this.ApeidoMaterno.Font = new System.Drawing.Font("Britannic Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ApeidoMaterno.ForeColor = System.Drawing.SystemColors.InfoText;
            this.ApeidoMaterno.Location = new System.Drawing.Point(12, 16);
            this.ApeidoMaterno.Name = "ApeidoMaterno";
            this.ApeidoMaterno.Size = new System.Drawing.Size(108, 16);
            this.ApeidoMaterno.TabIndex = 89;
            this.ApeidoMaterno.Text = "Buscar Nombre";
            // 
            // VerDatos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 167);
            this.Controls.Add(this.splitContainer1);
            this.Name = "VerDatos";
            this.Text = "VerDatos";
            this.Load += new System.EventHandler(this.VerDatos_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.boxtext.ResumeLayout(false);
            this.boxtext.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Panel MenuInfo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox boxtext;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Label ApeidoMaterno;
    }
}