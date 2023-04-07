using Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Service.Hall
{
    public interface IHallService
    {
        List<MeetingHallModel> GetName();
    }
}
