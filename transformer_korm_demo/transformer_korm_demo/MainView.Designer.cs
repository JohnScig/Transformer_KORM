namespace transformer_korm_demo
{
    partial class MainView
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
            this.dgv_mainGridView = new System.Windows.Forms.DataGridView();
            this.btn_loadCustomers = new System.Windows.Forms.Button();
            this.btn_LoadOrders = new System.Windows.Forms.Button();
            this.btn_Update = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_mainGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_mainGridView
            // 
            this.dgv_mainGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_mainGridView.Location = new System.Drawing.Point(12, 12);
            this.dgv_mainGridView.Name = "dgv_mainGridView";
            this.dgv_mainGridView.Size = new System.Drawing.Size(776, 348);
            this.dgv_mainGridView.TabIndex = 0;
            // 
            // btn_loadCustomers
            // 
            this.btn_loadCustomers.Location = new System.Drawing.Point(648, 366);
            this.btn_loadCustomers.Name = "btn_loadCustomers";
            this.btn_loadCustomers.Size = new System.Drawing.Size(140, 23);
            this.btn_loadCustomers.TabIndex = 1;
            this.btn_loadCustomers.Text = "Load Customers";
            this.btn_loadCustomers.UseVisualStyleBackColor = true;
            this.btn_loadCustomers.Click += new System.EventHandler(this.btn_loadCustomers_Click);
            // 
            // btn_LoadOrders
            // 
            this.btn_LoadOrders.Location = new System.Drawing.Point(648, 395);
            this.btn_LoadOrders.Name = "btn_LoadOrders";
            this.btn_LoadOrders.Size = new System.Drawing.Size(140, 23);
            this.btn_LoadOrders.TabIndex = 2;
            this.btn_LoadOrders.Text = "Load Orders";
            this.btn_LoadOrders.UseVisualStyleBackColor = true;
            this.btn_LoadOrders.Click += new System.EventHandler(this.btn_LoadOrders_Click);
            // 
            // btn_Update
            // 
            this.btn_Update.Location = new System.Drawing.Point(648, 424);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(140, 23);
            this.btn_Update.TabIndex = 3;
            this.btn_Update.Text = "Save";
            this.btn_Update.UseVisualStyleBackColor = true;
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 468);
            this.Controls.Add(this.btn_Update);
            this.Controls.Add(this.btn_LoadOrders);
            this.Controls.Add(this.btn_loadCustomers);
            this.Controls.Add(this.dgv_mainGridView);
            this.Name = "MainView";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_mainGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_mainGridView;
        private System.Windows.Forms.Button btn_loadCustomers;
        private System.Windows.Forms.Button btn_LoadOrders;
        private System.Windows.Forms.Button btn_Update;
    }
}

