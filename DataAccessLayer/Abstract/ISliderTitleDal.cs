using EntityLayer.Entity;

namespace DataAccessLayer.Abstract
{
    public interface ISliderTitleDal : IGenericDal<SliderTitle>
    {
        public List<SliderTitle> GetTrueImage();
    }

}
