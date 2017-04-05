﻿using SOLIDPrinciplesDemo.Common;

namespace SOLIDPrinciplesDemo.UserPromptValidationService
{
    public class UserPromptValidationResult : ValidationResult
    {
        public string FailureReason { get; }
        public bool Successful { get; }

        public UserPromptValidationResult(bool Successful, string FailureReason)
        {
            this.Successful = Successful;
            this.FailureReason = FailureReason;
        }
    }
}
