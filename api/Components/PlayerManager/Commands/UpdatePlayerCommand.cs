using MediatR;

namespace api.Components.PlayerManager
{
    public class UpdatePlayerCommand : IRequest<long>
    {
        public long Id {get; set;}
        public int MemberId { get; set; }
        public string Position { get; set; }
        public int JerseyNumber {get; set;}
        public decimal Height { get; set; }
        public decimal Weight { get; set; }
        public DateTime DateOfBirth {get; set;}
        public int GraduationYear { get; set; }
        public int CurrentGrade { get; set; }

        public UpdatePlayerCommand(long id, int memberId, string position, int jerseyNumber, decimal height, decimal weight, DateTime dateOfBirth, int graduationYear, int currentGrade)
        {
            Id = id;
            MemberId = memberId;
            Position = position;
            JerseyNumber = jerseyNumber;
            Height = height;
            Weight = weight;
            DateOfBirth = dateOfBirth;
            GraduationYear = graduationYear;
            CurrentGrade = currentGrade;
        }
    }
}