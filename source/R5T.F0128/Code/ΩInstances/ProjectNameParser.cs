using System;


namespace R5T.F0128
{
    public class ProjectNameParser : IProjectNameParser
    {
        #region Infrastructure

        public static IProjectNameParser Instance { get; } = new ProjectNameParser();


        private ProjectNameParser()
        {
        }

        #endregion
    }
}
