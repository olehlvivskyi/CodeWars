namespace CodeWars.Solution._7kyu;

// Happy Little Trees
// https://www.codewars.com/kata/56a8f83d96d99a315a0000a0
public class HappyLittleTrees
{
    public class Branch(int trunk)
    {
        public int Length { get; set; } = 1;
        public int Trunk { get; set; } = trunk;
        
        public void GrowBranch()
        {
            Length += 1;
        }
    }
    
    public class Tree : ITree
    {
        private int _trunk = 1;
        private readonly List<Branch> _branches = new();

        public void GrowTrunk()
        {
            _trunk += 1;
        }

        public void GrowBranches()
        {
            _branches.ForEach(branch => branch.GrowBranch());
        }

        public void NewBranch()
        {
            _branches.Add(new Branch(_trunk));
        }

        public void Ouch(int n)
        {
            if (n > 0 && n <= _branches.Count) 
            {
                _branches.RemoveAt(n - 1);
            }
        }

        public string Description()
        {
            return _branches.Any()
                ? $"The tree trunk is {_trunk} unit(s) tall! There are {_branches.Count} branch(es) that have position(s): {string.Join(",", _branches.Select(b => b.Trunk))} and length(s): {string.Join(",", _branches.Select(b => b.Length))}!"
                : $"The tree trunk is {_trunk} unit(s) tall! There are 0 branch(es)!";
        }
    }

    // This class is created to avoid errors.
    public interface ITree
    {
        void GrowTrunk();
        void GrowBranches();
        void NewBranch();
        void Ouch(int n);
        string Description();
    }
}