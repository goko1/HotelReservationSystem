namespace GUI
{
    partial class ReservationSelectRoom
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
            this.dtRooms = new System.Windows.Forms.DataGridView();
            this.btnAddRoom = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.lstSelectedRooms = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtRooms)).BeginInit();
            this.SuspendLayout();
            // 
            // dtRooms
            // 
            this.dtRooms.AllowUserToAddRows = false;
            this.dtRooms.AllowUserToDeleteRows = false;
            this.dtRooms.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtRooms.Location = new System.Drawing.Point(13, 13);
            this.dtRooms.Name = "dtRooms";
            this.dtRooms.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtRooms.Size = new System.Drawing.Size(420, 541);
            this.dtRooms.TabIndex = 0;
            this.dtRooms.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dtRooms_DataError);
            // 
            // btnAddRoom
            // 
            this.btnAddRoom.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAddRoom.Location = new System.Drawing.Point(449, 13);
            this.btnAddRoom.Name = "btnAddRoom";
            this.btnAddRoom.Size = new System.Drawing.Size(75, 60);
            this.btnAddRoom.TabIndex = 1;
            this.btnAddRoom.Text = ">";
            this.btnAddRoom.UseVisualStyleBackColor = true;
            this.btnAddRoom.Click += new System.EventHandler(this.btnAddRoom_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(449, 133);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 60);
            this.button1.TabIndex = 2;
            this.button1.Text = "<";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // lstSelectedRooms
            // 
            this.lstSelectedRooms.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lstSelectedRooms.FormattingEnabled = true;
            this.lstSelectedRooms.ItemHeight = 31;
            this.lstSelectedRooms.Location = new System.Drawing.Point(540, 13);
            this.lstSelectedRooms.Name = "lstSelectedRooms";
            this.lstSelectedRooms.Size = new System.Drawing.Size(330, 190);
            this.lstSelectedRooms.TabIndex = 3;
            // 
            // ReservationSelectRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 566);
            this.Controls.Add(this.lstSelectedRooms);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnAddRoom);
            this.Controls.Add(this.dtRooms);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ReservationSelectRoom";
            this.Text = "ReservationSelectRoom";
            this.Load += new System.EventHandler(this.ReservationSelectRoom_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtRooms)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtRooms;
        private System.Windows.Forms.Button btnAddRoom;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox lstSelectedRooms;
    }
}