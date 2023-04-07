using Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Service.Hall
{
    public class HallService:IHallService
    {
        public List<MeetingHallModel> GetName()
        {
            List<MeetingHallModel> hall = new List<MeetingHallModel>();
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
            return hall;
        }
    }
}
