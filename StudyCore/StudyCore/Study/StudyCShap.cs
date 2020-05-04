namespace StudyCore.Study

{
    public class StudyCShapFirst
    {
        private ITestWebservice Itw;
        public StudyCShapFirst(ITestWebservice inItw)
        {
            Itw = inItw;
        }
        public int Add(int intValA = 0, int intValB = 0)
        {
            intValA = Itw.test(intValA);
            if (intValA == 0)
            {
                return intValB;
            }
            else if (intValB == 0)
            {
                return intValA;
            }
            else
            {
                return intValA + intValB;
            }
        }
    }
}
