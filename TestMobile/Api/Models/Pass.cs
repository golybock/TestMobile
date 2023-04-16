using System;
using System.Text.Json.Serialization;

namespace TestMobile.Api.Models;

public partial class Pass
{
    [JsonPropertyName("groupId")] public int? GroupId { get; set; }
    [JsonPropertyName("subdivisionId")] public int? SubdivisionId { get; set; }
    [JsonPropertyName("workerId")] public int? WorkerId { get; set; }
    [JsonPropertyName("targetId")] public int? TargetId { get; set; }
    [JsonPropertyName("token")] public string? Token { get; set; }
    [JsonPropertyName("startDate")] public DateTime? StartDate { get; set; }
    [JsonPropertyName("endDate")] public DateTime? EndDate { get; set; }
    [JsonPropertyName("arrivalDatetime")] public DateTime? ArrivalDatetime { get; set; }

    [JsonPropertyName("departmentDatetime")]
    public DateTime? DepartmentDatetime { get; set; }

    [JsonPropertyName("subdivisionArrivalDatetime")]
    public DateTime? SubdivisionArrivalDatetime { get; set; }

    [JsonPropertyName("subdivisionDepartmentDatetime")]
    public DateTime? SubdivisionDepartmentDatetime { get; set; }
}