﻿// using DDD.ApplicationLayer;
// using DDD.DomainLayer;
// using COG.Commands;
// using COGDomain.IRepositories;
// using System;
// using System.Collections.Generic;
// using System.Linq;
// using System.Threading.Tasks;

// namespace COG.Handlers
// {
//     public class DeletePackageCommandHandler : ICommandHandler<DeletePackageCommand>
//     {
//         IPackageRepository repo;
//         IEventMediator mediator;
//         public DeletePackageCommandHandler(IPackageRepository repo, IEventMediator mediator)
//         {
//             this.repo = repo;
//             this.mediator = mediator;
//         }
//         public async Task HandleAsync(DeletePackageCommand command)
//         {
//             var deleted = await repo.Delete(command.PackageId);
//             if (deleted != null)
//                 await mediator.TriggerEvents(deleted.DomainEvents);
//             await repo.UnitOfWork.SaveEntitiesAsync();
//         }
//     }
// }
