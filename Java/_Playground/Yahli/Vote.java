public class Vote {
    public int first;
    public int second;
    public int third;

    public static void theWinner(Vote[] votes) {
        int[] songs = new int[40];

        for (int i = 0; i < votes.length; i++) {
            songs[votes[i].first - 1] += 7;
            songs[votes[i].second - 1] += 5;
            songs[votes[i].third - 1] += 1;
        }

        int topSongNumber = -1;
        int topSongScore = -1;
        for (int i = 0; i < songs.length; i++) {
            if (songs[i] > topSongScore) {
                topSongScore = songs[i];
                topSongNumber = i + 1;
            }
        }

        System.out.println(topSongNumber);
    }
}