public class Solution {
    public int EvalRPN(string[] tokens) {
        Stack<int> rpn = new Stack<int>();

        foreach(var ch in tokens){
            if(ch != "+" && ch != "-" && ch != "*" && ch != "/"){
                rpn.Push(int.Parse(ch));
            } else {
                rpn.Push(CalcExp(ch, rpn));
            }
        }

        return rpn.Peek();
    }

    public int CalcExp(string s, Stack<int> rpn){
        int i = rpn.Pop(); // Second operand
        int j = rpn.Pop(); // First operand
        int res;
        
        switch(s)
        {
            case "+":
                res = j + i;
                break;
            
            case "-":
                res = j - i;
                break;
            
            case "*":
                res = j * i;
                break;
            
            case "/":
                res = j / i;
                break;
            
            default:
                res = 0;
                break;
        }

        return res;
    }
}