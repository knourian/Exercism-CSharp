public class GradeSchool
{
    private Dictionary<string, int> _students = [];
    public bool Add(string student, int grade) => _students.TryAdd(student, grade);

    public IEnumerable<string> Roster() => _students.OrderBy(x => x.Value).ThenBy(x => x.Key).Select(x => x.Key).AsEnumerable();

    public IEnumerable<string> Grade(int grade) => _students.Where(x => x.Value == grade).OrderBy(x => x.Key).Select(x => x.Key).AsEnumerable();
}