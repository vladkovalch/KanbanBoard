﻿using BusinessLogicLayer.DTO;
using System;
using System.Collections.Generic;
using System.ServiceModel;

namespace BusinessLogicLayer.Interfaces.Contracts
{
	[ServiceContract]
	public interface ICardMgmtContract
	{
		[OperationContract]
		void AddCard(CardDTO card);

		[OperationContract]
		CardDTO FindCardById(int id);

		[OperationContract(Name = "GetAllCards")]
		IEnumerable<CardDTO> GetCards();

		[OperationContract]
		IEnumerable<CardDTO> GetCards(Func<CardDTO, bool> predicate);

		[OperationContract]
		void RemoveCard(CardDTO card);

		[OperationContract]
		void UpdateCard(CardDTO card);
	}
}