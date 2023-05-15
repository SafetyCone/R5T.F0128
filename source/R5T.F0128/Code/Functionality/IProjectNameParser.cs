using System;

using R5T.T0132;
using R5T.T0187;
using R5T.T0187.Extensions;


namespace R5T.F0128
{
    /// <summary>
    /// A parser (not a validator), that parses strings into project names.
    /// </summary>
    [FunctionalityMarker]
    public partial interface IProjectNameParser : IFunctionalityMarker
    {
        public IProjectName Ensure_IsValid(string projectName)
        {
            var output = Instances.FileNameOperator.Ensure_IsValid(projectName)
                .ToProjectName();

            return output;
        }

        public (IProjectName projectName, bool wasModified) Get_ProjectName(string projectName)
        {
            var ensuredProjectName = Instances.FileNameOperator.Ensure_IsValid(projectName);

            var wasModified = ensuredProjectName == projectName;

            var output = ensuredProjectName.ToProjectName();
            return (output, wasModified);
        }

        public bool Is_Valid(string projectName)
        {
            // Project names must be valid file names, so use the filename parsing logic.
            var output = Instances.FileNameOperator.Is_Valid(projectName);
            return output;
        }
    }
}
