using System;

public enum Gender { Male, Female };
public class ClubMember : IComparable
{
	public int Id { get; set; }
	public string FirstName { get; set; }
	public string LastName { get; set; }
	public Gender Gender { get; set; }
	public int Age { get; set; }

	public int CompareTo(object obj)
	{
		ClubMember clubmember = (ClubMember)(obj);

		if(this.FirstName.CompareTo(clubmember.FirstName) < 0)
		{
			return -1;
		}
		else if(this.FirstName.CompareTo(clubmember.FirstName) > 0)
		{
			return 1;
		}
		else
		{
			return 0;
		}

	}
	public class SortClubMembersAfterLastName : IComparer<ClubMember>
	{
		public int Compare(ClubMember first, ClubMember second)
		{
			throw new NotImplementedException();
		}
	}


	public override string ToString()
	{
		return $"{Id}: {FirstName} {LastName} ({Gender}, {Age} years)";
	}
}
