using EntityLayer.Entity;

namespace BusinessLayer.Abstract
{
    public interface ISliderTitleService : IGenericService<SliderTitle>
    {
        public List<SliderTitle> BusinessGetTrueImage();
    }
    
}
