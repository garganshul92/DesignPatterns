using Chain_Of_Responsibility_Design_Pattern.Models;

namespace Chain_Of_Responsibility_Design_Pattern.Interfaces;

public interface IApprover
{
    void SetNextApprover(IApprover approver);
    void Approve(PurchaseItem item);
}
