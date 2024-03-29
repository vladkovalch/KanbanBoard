﻿using BusinessLogicLayer.DTO;
using System;
using System.Collections.Generic;
using System.ServiceModel;

namespace BusinessLogicLayer.Interfaces.Contracts
{
	[ServiceContract]
	public interface IListMgmtContract
	{
		[OperationContract]
		void AddList(ListDTO list);

		[OperationContract]
		ListDTO FindListById(int id);

		[OperationContract(Name = "GetAllLists")]
		IEnumerable<ListDTO> GetLists();

		[OperationContract]
		IEnumerable<ListDTO> GetLists(Func<ListDTO, bool> predicate);

		[OperationContract]
		void RemoveList(ListDTO list);

		[OperationContract]
		void UpdateList(ListDTO list);
	}
}