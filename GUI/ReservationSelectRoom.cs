using BLL;
using Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class ReservationSelectRoom : Form
    {

        RoomController roomController;
        public ReservationSelectRoom()
        {
            InitializeComponent();
            roomController = new RoomController();
        }

        private void ReservationSelectRoom_Load(object sender, EventArgs e)
        {
            List < Room > rooms = roomController.GetRoomsEntity();
            dtRooms.DataSource = rooms;


            dtRooms.Columns.Remove("ID");
            dtRooms.Columns.Remove("RoomPrice");
            dtRooms.Columns.Remove("CreatedAt");
            dtRooms.Columns.Remove("IsActived");
            dtRooms.Columns.Remove("ExtraBedPriceRatio");
            dtRooms.Columns.Remove("WeekendPriceRatio");
            dtRooms.Columns.Remove("OneGuestInRoomPriceRatio");
            
            dtRooms.Columns.Add("Available", "Available");

            DataGridViewComboBoxColumn cmb = new DataGridViewComboBoxColumn();
            cmb.HeaderText = "Guests Count";
            cmb.Name = "cmb";
            cmb.MaxDropDownItems = 4;
            cmb.Items.Add(1);
            cmb.Items.Add(2);
            cmb.Items.Add(3);

            dtRooms.Columns.Add(cmb);
            

            dtRooms.Columns[0].ReadOnly = true;

            int roomNo = 0;
            foreach (DataGridViewRow row in dtRooms.Rows)
            {
                roomNo = (int)row.Cells["RoomNo"].Value;
                Room room = new Room();
                room.RoomNo = roomNo;
                room.ID = roomController.GetRoomId(room);
                ReservationRooms reservationRooms = new ReservationRooms();
                reservationRooms.Reservation = HelperStaticClass.reservationStatic;
                reservationRooms.Room = room;
                bool result = roomController.GetRoomAvailability(reservationRooms);
                if (!result)
                {
                    row.DefaultCellStyle.BackColor = Color.IndianRed;
                    row.Cells[1].Value = "Not Available";
                    row.ReadOnly = true;
                }
                else
                {
                    row.DefaultCellStyle.BackColor = Color.LightGreen;
                    row.Cells[1].Value = "Available";
                }
            }
        }

        private void btnAddRoom_Click(object sender, EventArgs e)
        {
            int selectedRoomNo = (int)dtRooms.SelectedRows[0].Cells[0].Value;
            string selectedGuestCount = dtRooms.SelectedRows[0].Cells[2].Value.ToString();


            if (!lstSelectedRooms.Items.Contains("Room: " + selectedRoomNo + " Guests: " +selectedGuestCount))
            {
                lstSelectedRooms.Items.Add("Room: " + selectedRoomNo + " Guests: " +selectedGuestCount);
            }

        }

        private void dtRooms_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.Cancel = true;
        }
    }
}
