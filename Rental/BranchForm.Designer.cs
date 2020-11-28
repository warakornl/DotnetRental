
namespace Rental
{
    partial class BranchForm
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
            this.label_header = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_previous = new System.Windows.Forms.Button();
            this.btl_next = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.text_in_branch_code = new System.Windows.Forms.TextBox();
            this.text_in_branch = new System.Windows.Forms.TextBox();
            this.text_in_manager = new System.Windows.Forms.TextBox();
            this.text_in_state = new System.Windows.Forms.TextBox();
            this.text_in_suburb = new System.Windows.Forms.TextBox();
            this.text_in_address = new System.Windows.Forms.TextBox();
            this.text_in_post_code = new System.Windows.Forms.TextBox();
            this.text_in_phone = new System.Windows.Forms.TextBox();
            this.text_in_fax = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label_header
            // 
            this.label_header.AutoSize = true;
            this.label_header.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_header.Location = new System.Drawing.Point(356, 56);
            this.label_header.Name = "label_header";
            this.label_header.Size = new System.Drawing.Size(152, 37);
            this.label_header.TabIndex = 10;
            this.label_header.Text = "Branches";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Lime;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 110);
            this.label1.TabIndex = 9;
            this.label1.Text = "Bee Car\r\nRentel";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(40, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "Branch Code";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(40, 193);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "Branch";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(40, 222);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 20);
            this.label5.TabIndex = 13;
            this.label5.Text = "Manager";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(158, 294);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 20);
            this.label6.TabIndex = 14;
            this.label6.Text = "Phone";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(158, 324);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 20);
            this.label7.TabIndex = 15;
            this.label7.Text = "Fax";
            // 
            // btn_add
            // 
            this.btn_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add.Location = new System.Drawing.Point(162, 362);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(92, 36);
            this.btn_add.TabIndex = 16;
            this.btn_add.Text = "Add";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click_1);
            // 
            // btn_update
            // 
            this.btn_update.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_update.Location = new System.Drawing.Point(289, 362);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(92, 36);
            this.btn_update.TabIndex = 17;
            this.btn_update.Text = "Update";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete.Location = new System.Drawing.Point(416, 362);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(92, 36);
            this.btn_delete.TabIndex = 18;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_previous
            // 
            this.btn_previous.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_previous.Location = new System.Drawing.Point(222, 411);
            this.btn_previous.Name = "btn_previous";
            this.btn_previous.Size = new System.Drawing.Size(92, 32);
            this.btn_previous.TabIndex = 19;
            this.btn_previous.Text = "<<";
            this.btn_previous.UseVisualStyleBackColor = true;
            this.btn_previous.Click += new System.EventHandler(this.btn_previous_Click);
            // 
            // btl_next
            // 
            this.btl_next.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btl_next.Location = new System.Drawing.Point(355, 411);
            this.btl_next.Name = "btl_next";
            this.btl_next.Size = new System.Drawing.Size(92, 32);
            this.btl_next.TabIndex = 20;
            this.btl_next.Text = ">>";
            this.btl_next.UseVisualStyleBackColor = true;
            this.btl_next.Click += new System.EventHandler(this.btl_next_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(488, 165);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 20);
            this.label8.TabIndex = 21;
            this.label8.Text = "Address";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(488, 193);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(61, 20);
            this.label9.TabIndex = 22;
            this.label9.Text = "Suburb";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(488, 222);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(48, 20);
            this.label10.TabIndex = 23;
            this.label10.Text = "State";
            this.label10.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(488, 255);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(83, 20);
            this.label11.TabIndex = 24;
            this.label11.Text = "Post Code";
            this.label11.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // text_in_branch_code
            // 
            this.text_in_branch_code.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_in_branch_code.Location = new System.Drawing.Point(162, 165);
            this.text_in_branch_code.Name = "text_in_branch_code";
            this.text_in_branch_code.Size = new System.Drawing.Size(165, 26);
            this.text_in_branch_code.TabIndex = 25;
            // 
            // text_in_branch
            // 
            this.text_in_branch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_in_branch.ForeColor = System.Drawing.SystemColors.WindowText;
            this.text_in_branch.Location = new System.Drawing.Point(162, 195);
            this.text_in_branch.Name = "text_in_branch";
            this.text_in_branch.Size = new System.Drawing.Size(165, 26);
            this.text_in_branch.TabIndex = 26;
            // 
            // text_in_manager
            // 
            this.text_in_manager.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_in_manager.Location = new System.Drawing.Point(162, 225);
            this.text_in_manager.Name = "text_in_manager";
            this.text_in_manager.Size = new System.Drawing.Size(165, 26);
            this.text_in_manager.TabIndex = 27;
            // 
            // text_in_state
            // 
            this.text_in_state.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_in_state.Location = new System.Drawing.Point(597, 225);
            this.text_in_state.Name = "text_in_state";
            this.text_in_state.Size = new System.Drawing.Size(165, 26);
            this.text_in_state.TabIndex = 30;
            // 
            // text_in_suburb
            // 
            this.text_in_suburb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_in_suburb.Location = new System.Drawing.Point(597, 195);
            this.text_in_suburb.Name = "text_in_suburb";
            this.text_in_suburb.Size = new System.Drawing.Size(165, 26);
            this.text_in_suburb.TabIndex = 29;
            // 
            // text_in_address
            // 
            this.text_in_address.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_in_address.Location = new System.Drawing.Point(597, 165);
            this.text_in_address.Name = "text_in_address";
            this.text_in_address.Size = new System.Drawing.Size(165, 26);
            this.text_in_address.TabIndex = 28;
            // 
            // text_in_post_code
            // 
            this.text_in_post_code.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_in_post_code.Location = new System.Drawing.Point(597, 255);
            this.text_in_post_code.Name = "text_in_post_code";
            this.text_in_post_code.Size = new System.Drawing.Size(165, 26);
            this.text_in_post_code.TabIndex = 31;
            // 
            // text_in_phone
            // 
            this.text_in_phone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_in_phone.Location = new System.Drawing.Point(233, 291);
            this.text_in_phone.Name = "text_in_phone";
            this.text_in_phone.Size = new System.Drawing.Size(275, 26);
            this.text_in_phone.TabIndex = 32;
            // 
            // text_in_fax
            // 
            this.text_in_fax.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_in_fax.Location = new System.Drawing.Point(233, 321);
            this.text_in_fax.Name = "text_in_fax";
            this.text_in_fax.Size = new System.Drawing.Size(275, 26);
            this.text_in_fax.TabIndex = 33;
            // 
            // BranchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.text_in_fax);
            this.Controls.Add(this.text_in_phone);
            this.Controls.Add(this.text_in_post_code);
            this.Controls.Add(this.text_in_state);
            this.Controls.Add(this.text_in_suburb);
            this.Controls.Add(this.text_in_address);
            this.Controls.Add(this.text_in_manager);
            this.Controls.Add(this.text_in_branch);
            this.Controls.Add(this.text_in_branch_code);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btl_next);
            this.Controls.Add(this.btn_previous);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label_header);
            this.Controls.Add(this.label1);
            this.Name = "BranchForm";
            this.Text = "Branch";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_header;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_previous;
        private System.Windows.Forms.Button btl_next;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox text_in_branch_code;
        private System.Windows.Forms.TextBox text_in_branch;
        private System.Windows.Forms.TextBox text_in_manager;
        private System.Windows.Forms.TextBox text_in_state;
        private System.Windows.Forms.TextBox text_in_suburb;
        private System.Windows.Forms.TextBox text_in_address;
        private System.Windows.Forms.TextBox text_in_post_code;
        private System.Windows.Forms.TextBox text_in_phone;
        private System.Windows.Forms.TextBox text_in_fax;
    }
}