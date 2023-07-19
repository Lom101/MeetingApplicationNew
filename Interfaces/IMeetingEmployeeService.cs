﻿using MeetingApplication.DTO;

namespace MeetingApplication.Interfaces
{
    public interface IMeetingEmployeeService
    {
        public IList<MeetingEmployeeDTO> GetMeetingEmployee();
        public void AddMeetingEmployee(int meetingId, int employeeId, int roleId);
        public bool PossibleToAddOrganizer(int meetingId);
        public bool EmployeeInAnotherMeetingCheck(int employeeId);
        public EmployeeDTO? GetOrganizer(int meetingId);
        //public void RemoveMeetingEmployee();
        //public void UpdateMeetingEmployee();
    }
}
