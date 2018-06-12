

namespace Sitecore.Support.WFFM.Analytics.Aggregation.Processors.FormFieldValues
{
  using System;
  using System.Security.Cryptography;
  using System.Text;
  using Sitecore.Analytics.Aggregation.Data.Model;
  using Sitecore.Diagnostics;

  public class FormFieldValues : Dimension<FormFieldValuesKey, FormFieldValuesValue>
  {
    public void Add(Guid submitId, Guid fieldId, string fieldName, string fieldValue)
    {
      Assert.ArgumentNotNull(submitId, nameof(submitId));
      Assert.ArgumentNotNull(fieldId, nameof(fieldId));
      Assert.ArgumentNotNull(fieldName, nameof(fieldName));

      if (string.IsNullOrEmpty(fieldValue))
      {
        return;
      }

      Add(new FormFieldValuesKey(submitId, fieldId, fieldName, fieldValue), new FormFieldValuesValue());
    }
  }
}