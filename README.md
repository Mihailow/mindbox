# Вопрос №1: 

Был опыт в разработке мессенджера в качестве курсовой работы. К сожалению проект был потерян.

# Вопрос №2	
  
Библиотека (https://github.com/Mihailow/mindbox/blob/master/mindbox_bramnik/FigureCalculator.cs)

Юнит-тест (https://github.com/Mihailow/mindbox/blob/master/mindbox_bramnik_test/UnitTest1.cs)

# Вопрос №3: 

SELECT prod.name [продукт], cat.name [категория] FROM Products prod
	LEFT FOIN ProdCat prodcat ON prod.id = prodcat.products_id
	INNER JOIN Category cat ON cat.id = prodcat.category_id
	ORDER BY prod.name;