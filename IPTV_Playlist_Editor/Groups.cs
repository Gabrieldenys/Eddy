using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kodi_M3U_IPTV_Editor
{
    public partial class Groups : Form
    {
        List<string> _groups;

        public List<GroupObj> DeleteGroupList
        {
            get;
            set;
        }

        public Groups()
        {
            InitializeComponent();
            
        }

        public Groups(List<string> groups) : this()
        {
            _groups = groups;

            // Automatically resize the visible rows.
            groupsGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;

            // Set the DataGridView control's border.
            groupsGridView.BorderStyle = BorderStyle.Fixed3D;
            groupsGridView.AutoGenerateColumns = true;
            groupsGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            List<GroupObj> groupObjs = new List<GroupObj>();
            foreach(string group in groups.Distinct())
            {
                groupObjs.Add(new GroupObj(group));
            }

            groupsGridView.DataSource = groupObjs;
            groupsGridView.Show();
        }

        private void deleteGroupButton_Click(object sender, EventArgs e)
        {
            if (groupsGridView.SelectedCells.Count > 0)
            {
                List<GroupObj> selectedGroups = new List<GroupObj>();
                for (int i = 0; i < groupsGridView.SelectedCells.Count; i++)
                {
                    int selectedrowindex = groupsGridView.SelectedCells[i].RowIndex;

                    DataGridViewRow selectedRow = groupsGridView.Rows[selectedrowindex];

                    string a = Convert.ToString(selectedRow.Cells["Group"].Value);
                    selectedGroups.Add(new GroupObj(a));
                }

                this.DeleteGroupList = selectedGroups;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }
    }
}
