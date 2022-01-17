namespace ChainOfResponsibility.Demo;

internal record ExpenseReport(string Name, int Amount);

internal interface IManager
{
    void SetSupervisor(IManager manager);
    void ApproveRequest(ExpenseReport expenseReport);
}

internal class SeniorManager : IManager
{
    private IManager manager;
    public void ApproveRequest(ExpenseReport expenseReport)
    {
        if(expenseReport.Amount < 500) Console.WriteLine("Approved by Manager");
        else manager?.ApproveRequest(expenseReport);
    }

    public void SetSupervisor(IManager manager)
    {
        this.manager = manager;
    }
}

internal class VicePresident : IManager
{
    private IManager manager;
    public void ApproveRequest(ExpenseReport expenseReport)
    {
        if (expenseReport.Amount < 1000) Console.WriteLine("Approved by VP");
        else manager?.ApproveRequest(expenseReport);
    }

    public void SetSupervisor(IManager manager)
    {
        this.manager = manager;
    }
}

internal class COO : IManager
{
    private IManager manager;
    public void ApproveRequest(ExpenseReport expenseReport)
    {
        if (expenseReport.Amount < 5000) Console.WriteLine("Approved by COO");
        else Console.WriteLine("No approved");
    }

    public void SetSupervisor(IManager manager)
    {
        this.manager=manager;
    }
}