﻿using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BLL
{
    public class PhimBLL
    {
        PhimDAO phimDAO;
        public PhimBLL()
        {
            phimDAO = new PhimDAO();
        }
        public void setDGV(DataGridView dgv,ComboBox text)
        {
            List<Phim> list = new List<Phim>();
            foreach(Phim phim in phimDAO.GetAll())
            {
                if (text.Text=="Tất cả"||phim.TheLoai.Contains(text.Text))
                {
                    list.Add(phim);
                }
            }
            dgv.DataSource = list;
        }
        public void setCBB(ComboBox cbb)
        {
            List<string> tenphim = new List<string>();
            tenphim.Add("Tất cả");
            foreach(Phim phim in phimDAO.GetAll())
            {
                tenphim.Add(phim.TheLoai);
            }
            cbb.Items.AddRange(tenphim.Distinct().ToArray());
        }
        public void Add(TextBox ma, TextBox ten,ComboBox theloai,TextBox thoiluong,TextBox mota)
        {
            try
            {
                int id = Convert.ToInt32(ma.Text);
                string name = ten.Text;
                string type = theloai.Text;
                int dur = Convert.ToInt32(thoiluong.Text);
                string des = mota.Text;
                Phim phim = new Phim(id, name, type, dur, des);
                phimDAO.Insert(phim);
                MessageBox.Show("Thêm thành công");
            }
            catch(Exception e)
            {
                MessageBox.Show("Lỗi "+e.Message);
            }
        }
        public void Update(TextBox ma, TextBox ten, ComboBox theloai, TextBox thoiluong, TextBox mota)
        {
            try
            {
                int id = Convert.ToInt32(ma.Text);
                string name = ten.Text;
                string type = theloai.Text;
                int dur = Convert.ToInt32(thoiluong.Text);
                string des = mota.Text;
                Phim phim = new Phim(id, name, type, dur, des);
                phimDAO.Update(phim);
                MessageBox.Show("Sửa thành công");
            }
            catch (Exception e)
            {
                MessageBox.Show("Lỗi " + e.Message);
            }
        }
        public void Delete(TextBox maphim)
        {
            try
            {
                int id =Convert.ToInt32(maphim.Text);
                phimDAO.Delete(id);
                MessageBox.Show("Xóa thành công");
            }
            catch(Exception e)
            {
                MessageBox.Show("Lỗi "+e.Message);
            }
        }

        public void xuLySuKien(Button sender, TextBox txtMa, TextBox txtTen, ComboBox ccbTheLoai, TextBox txtThoiLuong, TextBox txtMoTa)
        {
            switch (sender.Text)
            {
                case "Thêm":
                    Add(txtMa,txtTen,ccbTheLoai,txtThoiLuong,txtMoTa);
                    break;
                case "Sửa":
                    Update(txtMa, txtTen, ccbTheLoai, txtThoiLuong, txtMoTa);;
                    break;
                case "Xóa":
                    Delete(txtMa);
                    break;
                default:
                    MessageBox.Show(sender.Text);
                    break;
            }

        }

        public void setInfo(DataGridView sender, TextBox txtMaPhim, TextBox txtTenPhim, ComboBox ccbTheLoai, TextBox txtThoiLuong, TextBox txtMoTa,int index)
        {
            if (index >= 0)
            {
                DataGridViewRow dr = sender.Rows[index];
                dr.Selected = true;
                try
                {
                    txtMaPhim.Text = dr.Cells["Id"].Value.ToString();
                    txtTenPhim.Text = dr.Cells["TenPhim"].Value.ToString();
                    txtThoiLuong.Text = dr.Cells["ThoiLuong"].Value.ToString();
                    txtMoTa.Text = dr.Cells["MoTa"].Value.ToString();
                    ccbTheLoai.Text = dr.Cells["TheLoai"].Value.ToString();
                }
                catch (Exception e)
                {
                    MessageBox.Show("Lỗi " + e.Message);
                }
            }
        }
    }
}
