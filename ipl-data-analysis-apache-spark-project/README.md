#  IPL_DATA_ANALYSIS_SPARK_PROJECT

https://github.com/user-attachments/assets/2cbdec13-4489-46d3-aee7-d6f7a7d4371d
       
 ## Intro
<ul>
  <li>We will be using the IPL dataset for analysis.</li>
  <li>The dataset will be uploaded to Amazon S3 for data storage.</li>
  <li>We will work in a Databricks environment for processing and analysis.</li>
  <li>Apache Spark will be used for data transformation and implementing business logic.</li>
  <li>SQL queries will be written to analyze the dataset.</li>
  <li>Visualizations will be created to gain better insights from the data.</li>
</ul>
                    
  

 ## Technology Used
 1. Python
 2. Numpy , matplotlib and Pandas to edit and filter out data from datasets.                                        
 3. Databricks Environement for Processing Code. <a href="https://dbc-0d56bb97-5db6.cloud.databricks.com/editor/notebooks/4414252411731025?o=554618243516471">Source Code</a>
 4. Amazon S3 for data Storage.
 5. Apache Spark for implementing Business Logics.
 6. Sql For executing queries.
 7. Dataset from dataworld.com <a href="https://data.world/raghu543/ipl-data-till-2017"> Dataset Link</a>

## Features
<ul>
  <li><strong>Data Storage on Amazon S3:</strong> The IPL dataset will be securely stored on Amazon S3, providing scalable and reliable data storage.</li>
  <li><strong>Databricks Environment:</strong> The project will be developed and executed in a Databricks environment, leveraging its capabilities for data processing and analysis.</li>
  <li><strong>Apache Spark for Data Transformation:</strong> Apache Spark will be used for efficient data transformation, enabling fast processing and large-scale computations.</li>
  <li><strong>SQL-Based Data Analysis:</strong> SQL will be utilized to query and analyze the IPL dataset, allowing users to extract valuable insights from the data.</li>
  <li><strong>Data Visualizations:</strong> Interactive visualizations will be created to provide a clear understanding of the IPL dataset and its trends, helping to make data-driven decisions.</li>
</ul>


## Insights

- **Impact of Wides and No Balls**: Only valid deliveries (excluding wides and no balls) are considered for further analysis to ensure accurate results.
  
- **Total and Average Runs by Match and Inning**: We aggregated the total and average runs scored in each match and inning, providing an overview of individual performances across different innings.

- **Running Total of Runs**: A running total of runs scored in each match for each over was calculated, helping track how runs accumulate during a match over time.

- **High-Impact Balls**: We flagged high-impact balls, including those with more than 6 runs (including extras) or those resulting in a wicket, allowing us to identify key moments in the game.

- **Match Date Analysis**: We extracted detailed time-based insights, such as the year, month, and day of the match, for conducting time-based analysis on IPL seasons.

- **Win Margin Categories**: Matches were categorized into 'High', 'Medium', and 'Low' win margins, based on the difference in runs between the winner and the loser, enabling better understanding of match dynamics.

- **Toss and Match Outcome**: We analyzed the impact of winning the toss on match outcomes, revealing the correlation between toss winners and match winners.

- **Player Name Normalization**: Player names were cleaned and standardized by removing non-alphanumeric characters and normalizing the text, ensuring consistency across datasets.

- **Player Batting Style**: We classified players based on their batting hand (left-handed or right-handed) to analyze trends based on batting style.

- **Veteran Player Status**: Players aged 35 and above were categorized as "Veterans," and their performance was analyzed separately to compare them with non-veterans.

- **Years Since Debut**: The number of years since a player's debut was dynamically calculated, providing insight into the experience level of players over the years.

- **Top Scoring Batsmen per Season**: We identified the top-scoring batsmen for each IPL season, based on the total runs scored, helping recognize consistent performers over time.

- **Economical Bowlers in Powerplay**: We found the most economical bowlers in the powerplay overs (first 6 overs) by calculating the average runs conceded per ball and their wicket-taking performance.

- **Impact of Toss on Match Outcomes**: We analyzed how winning the toss influenced match outcomes by comparing toss winners with match winners.

- **Average Runs in Wins**: We analyzed the average runs scored by batsmen in winning matches, highlighting the contributions of top scorers in matches won by their teams.

- **Venue-wise Score Distribution**: We explored the distribution of scores by venue, identifying venues with the highest average scores and the venue with the highest total runs.

- **Dismissal Types**: We examined the frequency of different dismissal types (e.g., bowled, caught, LBW) to understand the most common ways players get out during the matches.

- **Team Performance After Winning Toss**: We analyzed how teams performed after winning the toss, showing teams that were most successful in converting toss wins into match victories.
