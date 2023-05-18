using IkinciElAracIhaleSistemi.Entities.Entities.Bases;

namespace IkinciElAracIhaleSistemiSonKullanici.Validation.ValidationBase
{
	public abstract class ValidatorBase<TModel> where TModel : class, IModel
	{
		public bool IsValid { get; protected set; }
		public List<string> ValidationMessages { get;  }
		public TModel Model { get; }

		public ValidatorBase(TModel model)
		{
			Model = model;
			ValidationMessages = new List<string>();
			IsValid = true;
			OnValidate();
		}
		public abstract void OnValidate();

	}
}
