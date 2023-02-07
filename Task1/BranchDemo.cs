namespace Task1;

public class Task2
{
    public static void Main2(string[] args)
    {
        Branch head = new Branch("Head");
        
        Branch secl = new Branch("Sec l");
        
        Branch secr = new Branch("Sec r");
        
        Branch thirdsec = new Branch("Sec l Third ");

        Branch thirdl = new Branch("Sec r Third l");
        
        Branch thirdm = new Branch("Sec r Third m");
        
        Branch thirdr = new Branch("Sec r Third r");
        
        Branch thirdmchild = new Branch("Sec r Third m child");
        
        Branch thirdmchild2 = new Branch("Sec r Third m child 2");

        Branch thirdlchild = new Branch("Sec r Third l child");
        
        Branch thirdmchildchild = new Branch("Third m child child");
        
        thirdmchild.addBranch(thirdmchildchild);
        
        thirdm.addBranch(thirdmchild);
        thirdm.addBranch(thirdmchild2);
        
        thirdl.addBranch(thirdlchild);
        
        secr.addBranch(thirdl);
        secr.addBranch(thirdm);
        secr.addBranch(thirdr);
        
        secl.addBranch(thirdsec);
        
        head.addBranch(secr);
        head.addBranch(secl);
        
        Console.WriteLine("Depth = "+head.Depth());

    }
    
}