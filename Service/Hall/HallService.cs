using Microsoft.Extensions.Configuration;
using Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace Service.Hall
{
    public class HallService:IHallService
    {
        public List<MeetingHallModel> GetName()
        {
            /*List<MeetingHallModel> hall = new List<MeetingHallModel>();
            MeetingHallModel room = new MeetingHallModel
            {
                RowId = 1,
                HallName = "ABC",
                IsActive = true
            };
            hall.Add(room);
            MeetingHallModel room1 = new MeetingHallModel
            {
                RowId = 2,
                HallName = "XYZ",
                IsActive = true
            };
            hall.Add(room1);
            return hall;*/



            List<MeetingHallModel> hall = new List<MeetingHallModel>();

            string connString = ConfigurationExtensions.GetConnectionString(configuration, "DBConnection");
            SqlConnection conn = new SqlConnection(connString);
            conn.Open();

            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM Movie", conn);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            DataTable dt = ds.Tables[0];
            sda.Dispose();

            foreach (DataRow dr in dt.Rows)
            {
                MeetingHallModel m = new MeetingHallModel
                {
                    RowId = (int)dr["RowId"],
                    HallName = dr["HallName"].ToString(),
                    IsActive= (bool)dr["IsActive"]
                };
                hall.Add(m);
            }
            conn.Close();
            return hall;
        }
    }
}
