
namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblCusName = new System.Windows.Forms.Label();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.txtCustomerLastName = new System.Windows.Forms.TextBox();
            this.lblCusLastName = new System.Windows.Forms.Label();
            this.txtCustomerPrincipal = new System.Windows.Forms.TextBox();
            this.lblCusPrincipal = new System.Windows.Forms.Label();
            this.btnCalc = new System.Windows.Forms.Button();
            this.btnList = new System.Windows.Forms.Button();
            this.lblListFirstName = new System.Windows.Forms.Label();
            this.lblListSecondName = new System.Windows.Forms.Label();
            this.lblListCustomerBenefit = new System.Windows.Forms.Label();
            this.txtPeriod = new System.Windows.Forms.TextBox();
            this.lblMonth = new System.Windows.Forms.Label();
            this.txtListName = new System.Windows.Forms.TextBox();
            this.txtListLastName = new System.Windows.Forms.TextBox();
            this.txtListBenefit = new System.Windows.Forms.TextBox();
            this.customerManagerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.customerManagerBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCusName
            // 
            this.lblCusName.AutoSize = true;
            this.lblCusName.Location = new System.Drawing.Point(21, 69);
            this.lblCusName.Name = "lblCusName";
            this.lblCusName.Size = new System.Drawing.Size(121, 17);
            this.lblCusName.TabIndex = 0;
            this.lblCusName.Text = "Customer Name : ";
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Location = new System.Drawing.Point(24, 89);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(100, 22);
            this.txtCustomerName.TabIndex = 1;
            this.txtCustomerName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCustomerName_KeyPress);
            // 
            // txtCustomerLastName
            // 
            this.txtCustomerLastName.Location = new System.Drawing.Point(23, 146);
            this.txtCustomerLastName.Name = "txtCustomerLastName";
            this.txtCustomerLastName.Size = new System.Drawing.Size(100, 22);
            this.txtCustomerLastName.TabIndex = 3;
            this.txtCustomerLastName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCustomerLastName_KeyPress);
            // 
            // lblCusLastName
            // 
            this.lblCusLastName.AutoSize = true;
            this.lblCusLastName.Location = new System.Drawing.Point(20, 126);
            this.lblCusLastName.Name = "lblCusLastName";
            this.lblCusLastName.Size = new System.Drawing.Size(152, 17);
            this.lblCusLastName.TabIndex = 2;
            this.lblCusLastName.Text = "Customer Last Name : ";
            // 
            // txtCustomerPrincipal
            // 
            this.txtCustomerPrincipal.Location = new System.Drawing.Point(23, 200);
            this.txtCustomerPrincipal.Name = "txtCustomerPrincipal";
            this.txtCustomerPrincipal.Size = new System.Drawing.Size(100, 22);
            this.txtCustomerPrincipal.TabIndex = 5;
            this.txtCustomerPrincipal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCustomerPrincipal_KeyPress);
            // 
            // lblCusPrincipal
            // 
            this.lblCusPrincipal.AutoSize = true;
            this.lblCusPrincipal.Location = new System.Drawing.Point(20, 180);
            this.lblCusPrincipal.Name = "lblCusPrincipal";
            this.lblCusPrincipal.Size = new System.Drawing.Size(134, 17);
            this.lblCusPrincipal.TabIndex = 4;
            this.lblCusPrincipal.Text = "Customer Principal :";
            // 
            // btnCalc
            // 
            this.btnCalc.BackColor = System.Drawing.Color.Gray;
            this.btnCalc.Location = new System.Drawing.Point(199, 134);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(127, 50);
            this.btnCalc.TabIndex = 6;
            this.btnCalc.Text = "Calculate The Benefit";
            this.btnCalc.UseVisualStyleBackColor = false;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // btnList
            // 
            this.btnList.BackColor = System.Drawing.Color.Gray;
            this.btnList.Location = new System.Drawing.Point(199, 200);
            this.btnList.Name = "btnList";
            this.btnList.Size = new System.Drawing.Size(127, 59);
            this.btnList.TabIndex = 8;
            this.btnList.Text = "List Customers";
            this.btnList.UseVisualStyleBackColor = false;
            this.btnList.Click += new System.EventHandler(this.btnList_Click);
            // 
            // lblListFirstName
            // 
            this.lblListFirstName.AutoSize = true;
            this.lblListFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblListFirstName.Location = new System.Drawing.Point(409, 69);
            this.lblListFirstName.Name = "lblListFirstName";
            this.lblListFirstName.Size = new System.Drawing.Size(409, 29);
            this.lblListFirstName.TabIndex = 10;
            this.lblListFirstName.Text = "Customer Name and Benefit List : ";
            this.lblListFirstName.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblListSecondName
            // 
            this.lblListSecondName.AutoSize = true;
            this.lblListSecondName.Location = new System.Drawing.Point(536, 57);
            this.lblListSecondName.Name = "lblListSecondName";
            this.lblListSecondName.Size = new System.Drawing.Size(0, 17);
            this.lblListSecondName.TabIndex = 11;
            // 
            // lblListCustomerBenefit
            // 
            this.lblListCustomerBenefit.AutoSize = true;
            this.lblListCustomerBenefit.Location = new System.Drawing.Point(690, 57);
            this.lblListCustomerBenefit.Name = "lblListCustomerBenefit";
            this.lblListCustomerBenefit.Size = new System.Drawing.Size(0, 17);
            this.lblListCustomerBenefit.TabIndex = 12;
            // 
            // txtPeriod
            // 
            this.txtPeriod.Location = new System.Drawing.Point(23, 262);
            this.txtPeriod.Name = "txtPeriod";
            this.txtPeriod.Size = new System.Drawing.Size(100, 22);
            this.txtPeriod.TabIndex = 14;
            this.txtPeriod.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPeriod_KeyPress);
            // 
            // lblMonth
            // 
            this.lblMonth.AutoSize = true;
            this.lblMonth.Location = new System.Drawing.Point(21, 242);
            this.lblMonth.Name = "lblMonth";
            this.lblMonth.Size = new System.Drawing.Size(102, 17);
            this.lblMonth.TabIndex = 13;
            this.lblMonth.Text = "Period(Month):";
            // 
            // txtListName
            // 
            this.txtListName.Location = new System.Drawing.Point(414, 102);
            this.txtListName.Multiline = true;
            this.txtListName.Name = "txtListName";
            this.txtListName.ReadOnly = true;
            this.txtListName.Size = new System.Drawing.Size(129, 182);
            this.txtListName.TabIndex = 15;
            // 
            // txtListLastName
            // 
            this.txtListLastName.Location = new System.Drawing.Point(539, 102);
            this.txtListLastName.Multiline = true;
            this.txtListLastName.Name = "txtListLastName";
            this.txtListLastName.ReadOnly = true;
            this.txtListLastName.Size = new System.Drawing.Size(129, 182);
            this.txtListLastName.TabIndex = 16;
            // 
            // txtListBenefit
            // 
            this.txtListBenefit.Location = new System.Drawing.Point(664, 102);
            this.txtListBenefit.Multiline = true;
            this.txtListBenefit.Name = "txtListBenefit";
            this.txtListBenefit.ReadOnly = true;
            this.txtListBenefit.Size = new System.Drawing.Size(129, 183);
            this.txtListBenefit.TabIndex = 17;
            // 
            // customerManagerBindingSource
            // 
            this.customerManagerBindingSource.DataSource = typeof(WindowsFormsApp1.CustomerManager);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCoral;
            this.ClientSize = new System.Drawing.Size(850, 355);
            this.Controls.Add(this.txtListBenefit);
            this.Controls.Add(this.txtListLastName);
            this.Controls.Add(this.txtListName);
            this.Controls.Add(this.txtPeriod);
            this.Controls.Add(this.lblMonth);
            this.Controls.Add(this.lblListCustomerBenefit);
            this.Controls.Add(this.lblListSecondName);
            this.Controls.Add(this.lblListFirstName);
            this.Controls.Add(this.btnList);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.txtCustomerPrincipal);
            this.Controls.Add(this.lblCusPrincipal);
            this.Controls.Add(this.txtCustomerLastName);
            this.Controls.Add(this.lblCusLastName);
            this.Controls.Add(this.txtCustomerName);
            this.Controls.Add(this.lblCusName);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.customerManagerBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCusName;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.TextBox txtCustomerLastName;
        private System.Windows.Forms.Label lblCusLastName;
        private System.Windows.Forms.TextBox txtCustomerPrincipal;
        private System.Windows.Forms.Label lblCusPrincipal;
        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.Button btnList;
        private System.Windows.Forms.Label lblListFirstName;
        private System.Windows.Forms.Label lblListSecondName;
        private System.Windows.Forms.Label lblListCustomerBenefit;
        private System.Windows.Forms.TextBox txtPeriod;
        private System.Windows.Forms.Label lblMonth;
        private System.Windows.Forms.BindingSource customerManagerBindingSource;
        private System.Windows.Forms.TextBox txtListName;
        private System.Windows.Forms.TextBox txtListLastName;
        private System.Windows.Forms.TextBox txtListBenefit;
    }
}

