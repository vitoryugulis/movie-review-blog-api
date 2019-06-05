using System;
using System.Collections.Generic;
using System.IO;
using AutoMapper;
using Core.Models;
using Newtonsoft.Json;
using Repository.Implementations;

namespace ConsoleApp.MockarooReader
{
    public class MockarooFileHandler
    {

        private readonly IMapper mapper;

        public MockarooFileHandler()
        {
            this.mapper = AutoMapperConfiguration.Configure();
        }

        private List<JsonPost> ReadMockarooFile()
        {
            using (StreamReader r = new StreamReader("../Console.MockarooReader/MOCK_DATA.json"))
            {
                string json = r.ReadToEnd();
                List<JsonPost> items = JsonConvert.DeserializeObject<List<JsonPost>>(json);
                return items;
            }
        }

        public void InsertMockarooData()
        {
            var postRepository = new PostRepository();
            var jsonList = ReadMockarooFile();
            
            foreach (var jsonPost in jsonList)
            {
                var post = mapper.Map<Post>(jsonPost);
                postRepository.Add(post);
            }
        }

    }
}