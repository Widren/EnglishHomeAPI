﻿using BaseAPI.Core.Repositories;
using BaseAPI.Domain.Models;
using BaseAPI.Domain.Repositories;
using BaseAPI.Domain.Services.Communication;
using Microsoft.Extensions.Caching.Memory;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BaseAPI.Domain.Services
{
    public class SiparisService : ISiparisService
    {
        private readonly IUserRepository _usersRepository;
        private readonly ISiparisRepository _siparisRepository;
        private readonly IProductRepository _productRepository;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMemoryCache _cache;

        public SiparisService(ISiparisRepository siparisRepository, IUserRepository usersRepository, IProductRepository productRepository, IUnitOfWork unitOfWork, IMemoryCache cache)
        {
            _usersRepository = usersRepository;
            _productRepository = productRepository;
            _siparisRepository = siparisRepository;
            _unitOfWork = unitOfWork;
            _cache = cache;
        }

        public async Task<SiparisResponse> DeleteAsync(int id)
        {
            var existingSiparis = await _siparisRepository.FindByIdAsync(id);

            if (existingSiparis == null)
                return new SiparisResponse("Siparis not found.");

            try
            {

                await _unitOfWork.CompleteAsync();

                return new SiparisResponse(existingSiparis);
            }
            catch (Exception ex)
            {
                // Do some logging stuff
                return new SiparisResponse($"An error occurred when deleting the siparis: {ex.Message}");
            }
        }

        public async Task<IEnumerable<Siparis>> ListAsync()
        {
            return await _siparisRepository.ListAsync();
        }

        public async Task<SiparisResponse> SaveAsync(Siparis siparis)
        {
            try
            {
                await _siparisRepository.AddAsync(siparis);
                await _unitOfWork.CompleteAsync();

                return new SiparisResponse(siparis);
            }
            catch (Exception ex)
            {
                // Do some logging stuff
                return new SiparisResponse($"An error occurred when saving the siparis: {ex.Message}");
            }
        }

        public async Task<SiparisResponse> UpdateAsync(int id, Siparis siparis)
        {

            var existingSiparis = await _siparisRepository.FindByIdAsync(id);

            if (existingSiparis == null)
                return new SiparisResponse("Siparis not found.");

            existingSiparis.SiparisId = siparis.SiparisId;

            try
            {
                _siparisRepository.Update(existingSiparis);
                await _unitOfWork.CompleteAsync();

                return new SiparisResponse(existingSiparis);
            }
            catch (Exception ex)
            {
                // Do some logging stuff
                return new SiparisResponse($"An error occurred when updating the siparis: {ex.Message}");
            }
        }
        public async Task<IEnumerable<Siparis>> FindByUserIDAsync(int id)
        {
            return await _siparisRepository.FindByUserIDAsync(id);
        }

    }
}

