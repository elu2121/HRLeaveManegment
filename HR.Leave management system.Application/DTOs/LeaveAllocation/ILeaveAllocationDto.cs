namespace HR.Leave_management_system.Application.DTOs.LeaveAllocation
{
    /// <summary>
    /// Defines the properties required for leave allocation data.
    /// </summary>
    public interface ILeaveAllocationDto
    {
        int NumberOfDays { get; set; }

        int LeaveTypeId { get; set; }

        int Period { get; set; }
    }
}