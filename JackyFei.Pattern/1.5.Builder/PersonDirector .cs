namespace Jacky.Pattern
{
    /// <summary>
    ///如果少了PersonDirector，客户端创建一个人，需要调用三个方法，而且可能调用遗漏
    ///为此，必须新增PersonDirector类，进行统一管理
    /// </summary>
    public class PersonDirector
    {
        private readonly PersonBuilder _personBuilder;

        public PersonDirector(PersonBuilder builder)
        {
            _personBuilder = builder;
        }

        public void CreatePerson()
        {
            _personBuilder.BuildHead();
            _personBuilder.BuildBody();
            _personBuilder.BuildOther();
        }

    }
}