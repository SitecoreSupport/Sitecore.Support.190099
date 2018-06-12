namespace Sitecore.Support.WFFM.Analytics.Aggregation.Processors.FormFieldValues
{
  using System;
  using Sitecore.Analytics.Aggregation.Data.Model;
  public class FormFieldValuesKey : DictionaryKey
  {
    public FormFieldValuesKey(Guid submitId, Guid fieldId, string fieldName, string fieldValue)
    {
      SubmitId = submitId;
      FieldId = fieldId;
      FieldName = fieldName;
      FieldValue = fieldValue;
    }

    public Guid SubmitId { get; }

    public Guid FieldId { get; }

    public string FieldName { get; }

    public string FieldValue { get; }
  }
}