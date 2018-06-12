namespace Sitecore.Support.WFFM.Analytics.Aggregation.Processors.FormFieldValues
{
  using System;
  using Sitecore.Analytics.Aggregation.Data.Model;
  public class FormFieldValuesKey : DictionaryKey
  {
    public FormFieldValuesKey(Guid submitId)
    {
      SubmitId = submitId;
    }
    public Guid SubmitId { get; }
  }
}