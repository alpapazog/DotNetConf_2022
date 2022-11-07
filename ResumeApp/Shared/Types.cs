namespace Types;

public class ResumeModel {
    public string? About {get; set;}
    public List<ExperienceModel>? Experiences {get; set;}
    public List<EducationModel>? Educations {get; set;}

}

public class ExperienceModel {
    public string? CompanyName {get; set;}
    public string? Location {get; set;}
    public string? Title {get; set;}
    public string? DateStart {get; set;}
    public string? DateEnd {get; set;}
    public string? Description {get; set;}
}

public class EducationModel {
    public string? Institution {get; set;}
    public string? Location {get; set;}
    public string? Title {get; set;}
    public string? DateStart {get; set;}
    public string? DateEnd {get; set;}
    public string? Description {get; set;}
}