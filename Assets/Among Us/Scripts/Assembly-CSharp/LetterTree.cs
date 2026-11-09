public class LetterTree : System.Object
{
    public enum NodeTypes : System.Byte
    {
        NonTerm = 0,
        Terminal = 1,
        TerminalStrict = 2,
        TerminalExact = 3,
        TerminalUnbroken = 4,
}
    public class LetterNode : System.Object
    {
        public System.Char Letter;
        public LetterTree.NodeTypes Terminal;
        public LetterTree.LetterNode[] Children;
        public LetterTree.LetterNode[] SpecialChildren;
}
}
