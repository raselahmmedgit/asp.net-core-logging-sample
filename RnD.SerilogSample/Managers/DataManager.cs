using RnD.SerilogSample.Models;

namespace RnD.SerilogSample.Managers
{
    public class DataManager : IDataManager
    {
        private readonly IConfiguration _iConfiguration;

        public DataManager(IConfiguration iConfiguration)
        {
            _iConfiguration = iConfiguration;
        }

        public async Task<IEnumerable<CategoryViewModel>> GetCategoryAsync()
        {
            try
            {
                await Task.Yield();
                var categoryViewModelList = new List<CategoryViewModel>
                            {
                                new CategoryViewModel { CategoryId=1, CategoryName = "Fruit"},
                                new CategoryViewModel {CategoryId=2, CategoryName = "Car"},
                                new CategoryViewModel {CategoryId=3, CategoryName = "Cloth"},
                                new CategoryViewModel {CategoryId=4, CategoryName = "Book"},
                                new CategoryViewModel {CategoryId=5, CategoryName = "Shoe"},
                                new CategoryViewModel {CategoryId=6, CategoryName = "Wipper"},
                                new CategoryViewModel {CategoryId=7, CategoryName = "Laptop"},
                                new CategoryViewModel {CategoryId=8, CategoryName = "Desktop"},
                                new CategoryViewModel {CategoryId=9, CategoryName = "Notebook"},
                                new CategoryViewModel {CategoryId=10, CategoryName = "AC"},
                                new CategoryViewModel {CategoryId=11, CategoryName = "AC 001"},
                                new CategoryViewModel {CategoryId=12, CategoryName = "AC 002"},
                                new CategoryViewModel {CategoryId=13, CategoryName = "AC 003"},
                                new CategoryViewModel {CategoryId=14, CategoryName = "AC 004"},
                                new CategoryViewModel {CategoryId=15, CategoryName = "AC 005"},
                            };

                return categoryViewModelList;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<IEnumerable<ProductViewModel>> GetProductAsync()
        {
            try
            {
                await Task.Yield();
                var productViewModelList = new List<ProductViewModel>
                        {
                            new ProductViewModel {ProductId=1, ProductName="Apple", Price=15, CategoryId=1, CategoryName = "Fruit"},
                            new ProductViewModel {ProductId=2, ProductName="Mango", Price=20, CategoryId=1, CategoryName = "Fruit"},
                            new ProductViewModel {ProductId=3, ProductName="Orange", Price=15, CategoryId=1, CategoryName = "Fruit"},
                            new ProductViewModel {ProductId=4, ProductName="Banana", Price=20, CategoryId=1, CategoryName = "Fruit"},
                            new ProductViewModel {ProductId=5, ProductName="Licho", Price=15, CategoryId=1, CategoryName = "Fruit"},
                            new ProductViewModel {ProductId=6, ProductName="Jack Fruit", Price=20, CategoryId=1, CategoryName = "Fruit"},

                            new ProductViewModel {ProductId=7, ProductName="Toyota", Price=15000, CategoryId=2, CategoryName = "Car"},
                            new ProductViewModel {ProductId=8, ProductName="Nissan", Price=20000, CategoryId=2, CategoryName = "Car"},
                            new ProductViewModel {ProductId=9, ProductName="Tata", Price=50000, CategoryId=2, CategoryName = "Car"},
                            new ProductViewModel {ProductId=10, ProductName="Honda", Price=20000, CategoryId=2, CategoryName = "Car"},
                            new ProductViewModel {ProductId=11, ProductName="Kimi", Price=50000, CategoryId=2, CategoryName = "Car"},
                            new ProductViewModel {ProductId=12, ProductName="Suzuki", Price=20000, CategoryId=2, CategoryName = "Car"},
                            new ProductViewModel {ProductId=13, ProductName="Ferrari", Price=50000, CategoryId=2, CategoryName = "Car"},

                            new ProductViewModel {ProductId=14, ProductName="T Shirt", Price=20000, CategoryId=3, CategoryName = "Cloth"},
                            new ProductViewModel {ProductId=15, ProductName="Polo Shirt", Price=50000, CategoryId=3, CategoryName = "Cloth"},
                            new ProductViewModel {ProductId=16, ProductName="Shirt", Price=200, CategoryId=3, CategoryName = "Cloth"},
                            new ProductViewModel {ProductId=17, ProductName="Panjabi", Price=500, CategoryId=3, CategoryName = "Cloth"},
                            new ProductViewModel {ProductId=18, ProductName="Fotuya", Price=200, CategoryId=3, CategoryName = "Cloth"},
                            new ProductViewModel {ProductId=19, ProductName="Shari", Price=500, CategoryId=3, CategoryName = "Cloth"},
                            new ProductViewModel {ProductId=19, ProductName="Kamij", Price=400, CategoryId=3, CategoryName = "Cloth"},

                            new ProductViewModel {ProductId=20, ProductName="History", Price=20000, CategoryId=4, CategoryName = "Book"},
                            new ProductViewModel {ProductId=21, ProductName="Fire Out", Price=50000, CategoryId=4, CategoryName = "Book"},

                            new ProductViewModel {ProductId=22, ProductName="Apex", Price=200, CategoryId=5, CategoryName = "Shoe"},
                            new ProductViewModel {ProductId=23, ProductName="Bata", Price=500, CategoryId=5, CategoryName = "Shoe"},

                            new ProductViewModel {ProductId=24, ProductName="Acer", Price=200, CategoryId=8, CategoryName = "Desktop"},
                            new ProductViewModel {ProductId=25, ProductName="Dell", Price=500, CategoryId=8, CategoryName = "Desktop"},
                            new ProductViewModel {ProductId=26, ProductName="HP", Price=400, CategoryId=8, CategoryName = "Desktop"}

                        };

                return productViewModelList;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<IEnumerable<ProductViewModel>> GetProductByCategoryIdAsync(int categoryId)
        {
            try
            {
                var productViewModelList = await GetProductAsync();
                var productViewModelList2 = productViewModelList.Where(x => x.CategoryId == categoryId).ToList();

                return productViewModelList2;
            }
            catch (Exception)
            {
                throw;
            }
        }

		public async Task<IEnumerable<TreeviewViewModel>> GetTreeviewViewModelAsync()
		{
			try
			{
				await Task.Yield();
				var treeviewViewModel = new List<TreeviewViewModel>
							{
								new TreeviewViewModel { Id = 1, Name = "Item 1", ChildrenTitle = "Level 1", 
                                    ChildrenList = new List<TreeviewViewModel>
                                    {
									    new TreeviewViewModel {Id = 11, Name = "Item 1.1", ChildrenTitle = "Level 2",
										    ChildrenList = new List<TreeviewViewModel>
									        {
										        new TreeviewViewModel {Id = 111, Name = "Item 1.1.1", ChildrenTitle = "Level 3",
												    ChildrenList = new List<TreeviewViewModel>
											        {
												        new TreeviewViewModel {Id = 1111, Name = "Item 1.1.1.1", ChildrenTitle = "Level 4"},
												        new TreeviewViewModel {Id = 1112, Name = "Item 1.1.1.2", ChildrenTitle = "Level 4"},
												        new TreeviewViewModel {Id = 1113, Name = "Item 1.1.1.3", ChildrenTitle = "Level 4", IsChecked = true},
												        new TreeviewViewModel {Id = 1114, Name = "Item 1.1.1.4", ChildrenTitle = "Level 4"},
														new TreeviewViewModel {Id = 1115, Name = "Item 1.1.1.5", ChildrenTitle = "Level 4"}
													}
												},
										        new TreeviewViewModel {Id = 112, Name = "Item 1.1.2", ChildrenTitle = "Level 3"},
										        new TreeviewViewModel {Id = 113, Name = "Item 1.1.3", ChildrenTitle = "Level 3"},
												new TreeviewViewModel {Id = 114, Name = "Item 1.1.4", ChildrenTitle = "Level 3"}
											}
										},
										new TreeviewViewModel {Id=12, Name = "Item 1.2", ChildrenTitle = "Level 2",
											ChildrenList = new List<TreeviewViewModel>
											{
												new TreeviewViewModel {Id=121, Name = "Item 1.2.1", ChildrenTitle = "Level 3"},
												new TreeviewViewModel {Id = 122, Name = "Item 1.2.2", ChildrenTitle = "Level 3",
													ChildrenList = new List<TreeviewViewModel>
													{
														new TreeviewViewModel {Id = 1221, Name = "Item 1.2.2.1", ChildrenTitle = "Level 4", IsChecked = true},
														new TreeviewViewModel {Id = 1222, Name = "Item 1.2.2.2", ChildrenTitle = "Level 4"},
														new TreeviewViewModel {Id = 1223, Name = "Item 1.2.2.3", ChildrenTitle = "Level 4"},
														new TreeviewViewModel {Id = 1224, Name = "Item 1.2.2.4", ChildrenTitle = "Level 4"},
														new TreeviewViewModel {Id = 1225, Name = "Item 1.2.2.5", ChildrenTitle = "Level 4", IsChecked = true}
													}
												},
												new TreeviewViewModel {Id = 123, Name = "Item 1.2.3", ChildrenTitle = "Level 3"},
												new TreeviewViewModel {Id = 124, Name = "Item 1.2.4", ChildrenTitle = "Level 3"}
											}
                                        },
										new TreeviewViewModel {Id = 13, Name = "Item 1.3", ChildrenTitle = "Level 2",
											ChildrenList = new List<TreeviewViewModel>
											{
												new TreeviewViewModel {Id = 131, Name = "Item 1.3.1", ChildrenTitle = "Level 3"},
												new TreeviewViewModel {Id = 132, Name = "Item 1.3.2", ChildrenTitle = "Level 3"},
												new TreeviewViewModel {Id = 133, Name = "Item 1.3.3", ChildrenTitle = "Level 3"},
												new TreeviewViewModel {Id = 134, Name = "Item 1.3.4", ChildrenTitle = "Level 3",
													ChildrenList = new List<TreeviewViewModel>
													{
														new TreeviewViewModel {Id = 1341, Name = "Item 1.3.4.1", ChildrenTitle = "Level 4"},
														new TreeviewViewModel {Id = 1342, Name = "Item 1.3.4.2", ChildrenTitle = "Level 4"},
														new TreeviewViewModel {Id = 1343, Name = "Item 1.3.4.3", ChildrenTitle = "Level 4"},
														new TreeviewViewModel {Id = 1344, Name = "Item 1.3.4.4", ChildrenTitle = "Level 4", IsChecked = true},
														new TreeviewViewModel {Id = 1345, Name = "Item 1.3.4.5", ChildrenTitle = "Level 4", IsChecked = true}
													}
												}
											}
                                        }
									}
                                },
								new TreeviewViewModel {Id = 2, Name = "Item 2", ChildrenTitle = "Level 1",
									ChildrenList = new List<TreeviewViewModel>
									{
										new TreeviewViewModel {Id = 21, Name = "Item 2.1", ChildrenTitle = "Level 2",
											ChildrenList = new List<TreeviewViewModel>
											{
												new TreeviewViewModel {Id = 211, Name = "Item 2.1.1", ChildrenTitle = "Level 3",
													ChildrenList = new List<TreeviewViewModel>
													{
														new TreeviewViewModel {Id = 2111, Name = "Item 2.1.1.1", ChildrenTitle = "Level 4", IsChecked = true},
														new TreeviewViewModel {Id = 2112, Name = "Item 2.1.1.2", ChildrenTitle = "Level 4", IsChecked = true},
														new TreeviewViewModel {Id = 2113, Name = "Item 2.1.1.3", ChildrenTitle = "Level 4"},
														new TreeviewViewModel {Id = 2114, Name = "Item 2.1.1.4", ChildrenTitle = "Level 4"},
														new TreeviewViewModel {Id = 2115, Name = "Item 2.1.1.5", ChildrenTitle = "Level 4"}
													}
												},
												new TreeviewViewModel {Id = 212, Name = "Item 2.1.2", ChildrenTitle = "Level 3"},
												new TreeviewViewModel {Id = 213, Name = "Item 2.1.3", ChildrenTitle = "Level 3"},
												new TreeviewViewModel {Id = 214, Name = "Item 2.1.4", ChildrenTitle = "Level 3"}
											}
										},
										new TreeviewViewModel {Id = 22, Name = "Item 2.2", ChildrenTitle = "Level 2",
											ChildrenList = new List<TreeviewViewModel>
											{
												new TreeviewViewModel {Id = 221, Name = "Item 2.2.1", ChildrenTitle = "Level 3"},
												new TreeviewViewModel {Id = 222, Name = "Item 2.2.2", ChildrenTitle = "Level 3"},
												new TreeviewViewModel {Id = 223, Name = "Item 2.2.3", ChildrenTitle = "Level 3",
													ChildrenList = new List<TreeviewViewModel>
													{
														new TreeviewViewModel {Id = 2231, Name = "Item 2.2.3.1", ChildrenTitle = "Level 4"},
														new TreeviewViewModel {Id = 2232, Name = "Item 2.2.3.2", ChildrenTitle = "Level 4"},
														new TreeviewViewModel {Id = 2233, Name = "Item 2.2.3.3", ChildrenTitle = "Level 4", IsChecked = true},
														new TreeviewViewModel {Id = 2234, Name = "Item 2.2.3.4", ChildrenTitle = "Level 4"},
														new TreeviewViewModel {Id = 2235, Name = "Item 2.2.3.5", ChildrenTitle = "Level 4"}
													}
												},
												new TreeviewViewModel {Id = 224, Name = "Item 2.2.4", ChildrenTitle = "Level 3"}
											}
										},
										new TreeviewViewModel {Id = 23, Name = "Item 2.3", ChildrenTitle = "Level 2",
											ChildrenList = new List<TreeviewViewModel>
											{
												new TreeviewViewModel {Id = 231, Name = "Item 2.3.1", ChildrenTitle = "Level 3"},
												new TreeviewViewModel {Id = 232, Name = "Item 2.3.2", ChildrenTitle = "Level 3"},
												new TreeviewViewModel {Id = 233, Name = "Item 2.3.3", ChildrenTitle = "Level 3"},
												new TreeviewViewModel {Id = 234, Name = "Item 2.3.4", ChildrenTitle = "Level 3",
													ChildrenList = new List<TreeviewViewModel>
													{
														new TreeviewViewModel {Id = 2341, Name = "Item 2.3.4.1", ChildrenTitle = "Level 4"},
														new TreeviewViewModel {Id = 2342, Name = "Item 2.3.4.2", ChildrenTitle = "Level 4", IsChecked = true},
														new TreeviewViewModel {Id = 2343, Name = "Item 2.3.4.3", ChildrenTitle = "Level 4"},
														new TreeviewViewModel {Id = 2344, Name = "Item 2.3.4.4", ChildrenTitle = "Level 4"},
														new TreeviewViewModel {Id = 2345, Name = "Item 2.3.4.5", ChildrenTitle = "Level 4"}
													}
												}
											}
										}
									}
								},
								new TreeviewViewModel {Id = 3, Name = "Item 3", ChildrenTitle = "Level 1",
									ChildrenList = new List<TreeviewViewModel>
									{
										new TreeviewViewModel {Id = 31, Name = "Item 3.1", ChildrenTitle = "Level 2",
											ChildrenList = new List<TreeviewViewModel>
											{
												new TreeviewViewModel {Id = 311, Name = "Item 3.1.1", ChildrenTitle = "Level 3",
													ChildrenList = new List<TreeviewViewModel>
													{
														new TreeviewViewModel {Id = 3111, Name = "Item 3.1.1.1", ChildrenTitle = "Level 4", IsChecked = true},
														new TreeviewViewModel {Id = 3112, Name = "Item 3.1.1.2", ChildrenTitle = "Level 4", IsChecked = true},
														new TreeviewViewModel {Id = 3113, Name = "Item 3.1.1.3", ChildrenTitle = "Level 4"},
														new TreeviewViewModel {Id = 3114, Name = "Item 3.1.1.4", ChildrenTitle = "Level 4"},
														new TreeviewViewModel {Id = 3115, Name = "Item 3.1.1.5", ChildrenTitle = "Level 4"}
													}
												},
												new TreeviewViewModel {Id = 312, Name = "Item 3.1.2", ChildrenTitle = "Level 3"},
												new TreeviewViewModel {Id = 313, Name = "Item 3.1.3", ChildrenTitle = "Level 3"},
												new TreeviewViewModel {Id = 314, Name = "Item 3.1.4", ChildrenTitle = "Level 3"}
											}
										},
										new TreeviewViewModel {Id = 32, Name = "Item 3.2", ChildrenTitle = "Level 2",
											ChildrenList = new List<TreeviewViewModel>
											{
												new TreeviewViewModel {Id = 321, Name = "Item 3.2.1", ChildrenTitle = "Level 3"},
												new TreeviewViewModel {Id = 322, Name = "Item 3.2.2", ChildrenTitle = "Level 3"},
												new TreeviewViewModel {Id = 323, Name = "Item 3.2.3", ChildrenTitle = "Level 3",
													ChildrenList = new List<TreeviewViewModel>
													{
														new TreeviewViewModel {Id = 3231, Name = "Item 3.2.3.1", ChildrenTitle = "Level 4"},
														new TreeviewViewModel {Id = 3232, Name = "Item 3.2.3.2", ChildrenTitle = "Level 4"},
														new TreeviewViewModel {Id = 3233, Name = "Item 3.2.3.3", ChildrenTitle = "Level 4", IsChecked = true},
														new TreeviewViewModel {Id = 3234, Name = "Item 3.2.3.4", ChildrenTitle = "Level 4", IsChecked = true},
														new TreeviewViewModel {Id = 3235, Name = "Item 3.2.3.5", ChildrenTitle = "Level 4"}
													}
												},
												new TreeviewViewModel {Id = 324, Name = "Item 3.2.4", ChildrenTitle = "Level 3"}
											}							  
										},
										new TreeviewViewModel {Id = 33, Name = "Item 3.3", ChildrenTitle = "Level 2",
											ChildrenList = new List<TreeviewViewModel>
											{
												new TreeviewViewModel {Id = 331, Name = "Item 3.3.1", ChildrenTitle = "Level 3"},
												new TreeviewViewModel {Id = 332, Name = "Item 3.3.2", ChildrenTitle = "Level 3",
													ChildrenList = new List<TreeviewViewModel>
													{
														new TreeviewViewModel {Id = 3321, Name = "Item 3.3.2.1", ChildrenTitle = "Level 4"},
														new TreeviewViewModel {Id = 3322, Name = "Item 3.3.2.2", ChildrenTitle = "Level 4"},
														new TreeviewViewModel {Id = 3323, Name = "Item 3.3.2.3", ChildrenTitle = "Level 4", IsChecked = true},
														new TreeviewViewModel {Id = 3324, Name = "Item 3.3.2.4", ChildrenTitle = "Level 4", IsChecked = true},
														new TreeviewViewModel {Id = 3325, Name = "Item 3.3.2.5", ChildrenTitle = "Level 4", IsChecked = true}
													}
												},
												new TreeviewViewModel {Id = 333, Name = "Item 3.3.3", ChildrenTitle = "Level 3"},
												new TreeviewViewModel {Id = 334, Name = "Item 3.3.4", ChildrenTitle = "Level 3"}
											}
										}
									}
								},
								new TreeviewViewModel {Id = 4, Name = "Item 4", ChildrenTitle = "Level 1",
									ChildrenList = new List<TreeviewViewModel>
									{
										new TreeviewViewModel {Id = 41, Name = "Item 4.1", ChildrenTitle = "Level 2",
											ChildrenList = new List<TreeviewViewModel>
											{
												new TreeviewViewModel {Id = 411, Name = "Item 4.1.1", ChildrenTitle = "Level 3",
													ChildrenList = new List<TreeviewViewModel>
													{
														new TreeviewViewModel {Id = 4111, Name = "Item 4.1.1.1", ChildrenTitle = "Level 4"},
														new TreeviewViewModel {Id = 4112, Name = "Item 4.1.1.2", ChildrenTitle = "Level 4"},
														new TreeviewViewModel {Id = 4113, Name = "Item 4.1.1.3", ChildrenTitle = "Level 4"},
														new TreeviewViewModel {Id = 4114, Name = "Item 4.1.1.4", ChildrenTitle = "Level 4"},
														new TreeviewViewModel {Id = 4115, Name = "Item 4.1.1.5", ChildrenTitle = "Level 4"}
													}
												},
												new TreeviewViewModel {Id = 412, Name = "Item 4.1.2", ChildrenTitle = "Level 3"},
												new TreeviewViewModel {Id = 413, Name = "Item 4.1.3", ChildrenTitle = "Level 3"},
												new TreeviewViewModel {Id = 414, Name = "Item 4.1.4", ChildrenTitle = "Level 3"}
											}
										},
										new TreeviewViewModel {Id = 42, Name = "Item 4.2", ChildrenTitle = "Level 2",
											ChildrenList = new List<TreeviewViewModel>
											{
												new TreeviewViewModel {Id = 421, Name = "Item 4.2.1", ChildrenTitle = "Level 3"},
												new TreeviewViewModel {Id = 422, Name = "Item 4.2.2", ChildrenTitle = "Level 3"},
												new TreeviewViewModel {Id = 423, Name = "Item 4.2.3", ChildrenTitle = "Level 3",
													ChildrenList = new List<TreeviewViewModel>
													{
														new TreeviewViewModel {Id = 4231, Name = "Item 4.2.3.1", ChildrenTitle = "Level 4"},
														new TreeviewViewModel {Id = 4232, Name = "Item 4.2.3.2", ChildrenTitle = "Level 4"},
														new TreeviewViewModel {Id = 4233, Name = "Item 4.2.3.3", ChildrenTitle = "Level 4"},
														new TreeviewViewModel {Id = 4234, Name = "Item 4.2.3.4", ChildrenTitle = "Level 4"},
														new TreeviewViewModel {Id = 4235, Name = "Item 4.2.3.5", ChildrenTitle = "Level 4"}
													}
												},
												new TreeviewViewModel {Id = 424, Name = "Item 4.2.4", ChildrenTitle = "Level 3"}
											}
										},
									}
								}
							};

				return treeviewViewModel;
			}
			catch (Exception)
			{
				throw;
			}
		}

	}

	public interface IDataManager
    {
        Task<IEnumerable<CategoryViewModel>> GetCategoryAsync();
        Task<IEnumerable<ProductViewModel>> GetProductAsync();
        Task<IEnumerable<ProductViewModel>> GetProductByCategoryIdAsync(int categoryId);

		Task<IEnumerable<TreeviewViewModel>> GetTreeviewViewModelAsync();

	}
}
