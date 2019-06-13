using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace yuanzhan
{
    interface MyList<T>
    {
        int GetLength();                            //获取链表长度
        void Clear();                               //清空链表				
        bool IsEmpty();                             //判断链表是否为空
        void Add(T item);                           //在链表尾部添加新节点
        void AddPre(T item, int index);             //在指定节点前添加新节点
        void AddPost(T item, int index);                //在指定节点后添加新节点
        T Delete(int index);                        //按索引删除节点
        T Delete(T item, bool isSecond = true);     //按内容删除节点，如果有多个内容相同点，则删除第一个
        T this[int index] { get; }                  //实现下标访问
        T GetElem(int index);                       //根据索引返回元素
        int GetPos(T item);                         //根据元素返回索引地址
        void Print();                               //打印
    }

    
}

