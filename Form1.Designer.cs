
namespace Practica100921
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btngetnames = new System.Windows.Forms.Button();
            this.btngetdata = new System.Windows.Forms.Button();
            this.ltsProductsNames = new System.Windows.Forms.ListBox();
            this.dgAllProducts = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgAllProducts)).BeginInit();
            this.SuspendLayout();
            // 
            // btngetnames
            // 
            this.btngetnames.Location = new System.Drawing.Point(30, 97);
            this.btngetnames.Name = "btngetnames";
            this.btngetnames.Size = new System.Drawing.Size(160, 46);
            this.btngetnames.TabIndex = 0;
            this.btngetnames.Text = "getProductsNames()";
            this.btngetnames.UseVisualStyleBackColor = true;
            this.btngetnames.Click += new System.EventHandler(this.btngetnames_Click);
            // 
            // btngetdata
            // 
            this.btngetdata.Location = new System.Drawing.Point(30, 421);
            this.btngetdata.Name = "btngetdata";
            this.btngetdata.Size = new System.Drawing.Size(160, 33);
            this.btngetdata.TabIndex = 1;
            this.btngetdata.Text = "getAllProducts()";
            this.btngetdata.UseVisualStyleBackColor = true;
            this.btngetdata.Click += new System.EventHandler(this.btngetdata_Click);
            // 
            // ltsProductsNames
            // 
            this.ltsProductsNames.FormattingEnabled = true;
            this.ltsProductsNames.ItemHeight = 16;
            this.ltsProductsNames.Location = new System.Drawing.Point(258, 97);
            this.ltsProductsNames.Name = "ltsProductsNames";
            this.ltsProductsNames.Size = new System.Drawing.Size(248, 292);
            this.ltsProductsNames.TabIndex = 2;
            // 
            // dgAllProducts
            // 
            this.dgAllProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgAllProducts.Location = new System.Drawing.Point(217, 421);
            this.dgAllProducts.Name = "dgAllProducts";
            this.dgAllProducts.RowHeadersWidth = 51;
            this.dgAllProducts.RowTemplate.Height = 24;
            this.dgAllProducts.Size = new System.Drawing.Size(702, 234);
            this.dgAllProducts.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1054, 696);
            this.Controls.Add(this.dgAllProducts);
            this.Controls.Add(this.ltsProductsNames);
            this.Controls.Add(this.btngetdata);
            this.Controls.Add(this.btngetnames);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgAllProducts)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btngetnames;
        private System.Windows.Forms.Button btngetdata;
        private System.Windows.Forms.ListBox ltsProductsNames;
        private System.Windows.Forms.DataGridView dgAllProducts;
    }
}

