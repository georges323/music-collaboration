﻿namespace Application.Tracks.Queries;

public class TrackDto
{
    public Guid Id { get; set; }
    public string? Name { get; set; }
    public string? ImageUrl { get; set; }
    public Guid ProjectId { get; set; }
}
