using BilgeAdam.Events.Enums;
using System;
using System.Collections.Generic;

namespace BilgeAdam.Events.Models
{
    public class Parent
    {
        public string fullName;
        public Gender gender;
        public DateTime birthDate;
        public Parent spouse;
        public List<Child> children;

        public override string ToString()
        {
            return fullName;
        }

        public void SetSpouse(Parent spouse)
        {
            this.spouse = spouse;
            if(spouse.OnMatched != null)
            {
                spouse.OnMatched.Invoke(spouse, this);
            }
        }

        public event MatchedHandler OnMatched;
        public event ChildAddedHandler OnChildAdded;

        public void AddChildDuzYontem(Child child)
        {
            if (children == null)
            {
                children = new List<Child>();
            }
            children.Add(child);
            if (spouse != null)
            {
                spouse.AddChildDuzYontem(child);
            }
        }

        public void AddChild(Child child)
        {
            if (children == null)
            {
                children = new List<Child>();
            }
            foreach (var ch in children)
            {
                child.siblings.Add(ch);
                ch.siblings.Add(child);
            }
         
            if (this.OnChildAdded != null)
            {
                this.OnChildAdded.Invoke(this, child);
            }
            if (spouse.OnChildAdded != null)
            {
                spouse.OnChildAdded.Invoke(spouse, child);
            }
        }
    }

    public delegate void MatchedHandler(Parent self, Parent spouse);
    public delegate void ChildAddedHandler(Parent parent, Child child);
}
