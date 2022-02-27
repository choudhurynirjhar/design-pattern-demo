namespace InterpreterPattern.Demo;
internal interface IExpression
{
    void Evaluate(Context context);
}

internal class LowerCaseExpression : IExpression
{
    public void Evaluate(Context context)
    {
        context.Value = context.Value.ToLower();
    }
}

internal class UpperCaseExpression : IExpression
{
    public void Evaluate(Context context)
    {
        context.Value = context.Value.ToUpper();
    }
}