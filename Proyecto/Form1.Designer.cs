namespace Proyecto
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.nuevoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.balanceGeneralToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoBalanceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mostrarBalanceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.estadoDeResultadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // nuevoToolStripMenuItem
            // 
            this.nuevoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.balanceGeneralToolStripMenuItem,
            this.estadoDeResultadoToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.nuevoToolStripMenuItem.Name = "nuevoToolStripMenuItem";
            this.nuevoToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.nuevoToolStripMenuItem.Text = "Nuevo";
            // 
            // balanceGeneralToolStripMenuItem
            // 
            this.balanceGeneralToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoBalanceToolStripMenuItem,
            this.mostrarBalanceToolStripMenuItem});
            this.balanceGeneralToolStripMenuItem.Name = "balanceGeneralToolStripMenuItem";
            this.balanceGeneralToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.balanceGeneralToolStripMenuItem.Text = "Balance General";
            // 
            // nuevoBalanceToolStripMenuItem
            // 
            this.nuevoBalanceToolStripMenuItem.Name = "nuevoBalanceToolStripMenuItem";
            this.nuevoBalanceToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.nuevoBalanceToolStripMenuItem.Text = "Nuevo Balance";
            this.nuevoBalanceToolStripMenuItem.Click += new System.EventHandler(this.nuevoBalanceToolStripMenuItem_Click);
            // 
            // mostrarBalanceToolStripMenuItem
            // 
            this.mostrarBalanceToolStripMenuItem.Name = "mostrarBalanceToolStripMenuItem";
            this.mostrarBalanceToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.mostrarBalanceToolStripMenuItem.Text = "Mostrar balance";
            this.mostrarBalanceToolStripMenuItem.Click += new System.EventHandler(this.mostrarBalanceToolStripMenuItem_Click);
            // 
            // estadoDeResultadoToolStripMenuItem
            // 
            this.estadoDeResultadoToolStripMenuItem.Name = "estadoDeResultadoToolStripMenuItem";
            this.estadoDeResultadoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.estadoDeResultadoToolStripMenuItem.Text = "Estado de resultado";
            this.estadoDeResultadoToolStripMenuItem.Click += new System.EventHandler(this.estadoDeResultadoToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "MDI";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem nuevoToolStripMenuItem;
        private ToolStripMenuItem balanceGeneralToolStripMenuItem;
        private ToolStripMenuItem estadoDeResultadoToolStripMenuItem;
        private ToolStripMenuItem salirToolStripMenuItem;
        private ToolStripMenuItem nuevoBalanceToolStripMenuItem;
        private ToolStripMenuItem mostrarBalanceToolStripMenuItem;
    }
}