namespace Task1;

public class Branch
{
    private List<Branch> Branches;

    public string name;

    public Branch(string name)
    {
        Branches = new List<Branch>();
        this.name = name;
    }

    public void addBranch(Branch branch)
    {
        Branches.Add(branch);
    }
    
    public int Depth()
    {
        int max = 1;
        foreach (Branch i in Branches) 
        {
            int depth = i.Depth();
            if (depth >= max) max = depth + 1;
        }
        return max;
    }
}