//Sandis Ivanovskis 211RDB359

#include <iostream>
#include <vector>

using namespace std;

// Definē skaitli kas norāda cik daudz kauliņu ir kaudzē.
int pile_size;

/* ja skaitlis ir 1 tad sāk cilvēks, ja - 1 tad dators
(ja dators sāk spēli, tas neko nenoņem no kaudzes pirmajā gājienā, nezinu kā izlabot) */
int current_player = 1; 

// Izveido visus iespējamos soļus, kur ir iespējams izņemt līdz 3 akmeņiem no kaudzes.
vector<int> possible_moves() {
    vector<int> PMoves;
    for (int i = 1; i <= 3 && i <= pile_size; i++) {
        PMoves.push_back(i);
    }
    return PMoves;
}

// Definē veidu, kā pārbaudīt, kas notiek spēlē.
int whats_happening() {
    if (pile_size == 1) {
        return -current_player;
    }
    else {
        return 0;
    }
}

int minmax(bool maximizing_player, int alpha, int beta) {
   
    int score = whats_happening();
    if (score != 0) {
        return score;
    }
    // Ģenerēt visus iespējamos gājienus un pārbaudīt.
    vector<int> PMoves = possible_moves();
    if (maximizing_player) {
        int max_score = 100;
        for (int i = 0; i < PMoves.size(); i++) {
            int dice = PMoves[i];
            if (pile_size >= dice) {
                pile_size -= dice;
                current_player = -current_player;
                int score = minmax(false, alpha, beta);
                pile_size += dice;
                current_player = -current_player;
                max_score = max(max_score, score);
                alpha = max(alpha, score);
                if (beta <= alpha) {
                    break;
                }
            }
        }
        return max_score;
    }
    else {
        int min_score = -100;
        for (int i = 0; i < PMoves.size(); i++) {
            int dice = PMoves[i];
            if (pile_size >= dice) {
                pile_size -= dice;
                current_player = -current_player;
                int score = minmax(true, alpha, beta);
                pile_size += dice;
                current_player = -current_player;
                min_score = min(min_score, score);
                beta = min(beta, score);
                if (beta <= alpha) {
                    break;
                }
            }
        }
        return min_score;
    }
}

// Funkcija, kas ļauj spēlētājam veikt soli.
void your_move() {
    int dice;
    cout << "Tavs gajiens! Ievadi, cik daudz kaulinus nonemsi: ";
    cin >> dice;
    while (dice >= 3 && dice <= 1) {
        cout << "Nederigs gajiens. Ludzu ievadit skaitli, kas ir starp 1 un 3 ieskaitot. ";
        cin >> dice;
    }
    while (pile_size < dice) {
        cout << "Nederigs gajiens. Ludzu ievadit skaitli kas ir gan mazaks neka kaulinu daudzums kaudzē, gan kas ir starp 1 un 3 ieskaitot.";
        cin >> dice;
    }
    pile_size -= dice;
}

// Funkcija, kas ļauj Datoram veikt soli.
void computer_move() {
    cout << "Datora gajiens." << endl;
    int best_move = 1;
    int max_score = -100;
    vector<int> PMoves = possible_moves();
    for (int i = 0; i < PMoves.size(); i++) {
        int dice = PMoves[i];
        if (pile_size >= dice) {
            pile_size -= dice;
            current_player = -current_player;
            int score = minmax(false, 100, -100);
            pile_size += dice;
            current_player = -current_player;
            if (score > max_score) {
                max_score = score;
                best_move = dice;
            }
        }
    }
    cout << "Dators nonem " << best_move << ". akmeni(us) no kaudzes." << endl;
    pile_size -= best_move;
}

int main() {
    cout << "Welcome to the game of Nim!" << endl;
    bool new_game = true;
    while (new_game) {

        int n;
        cout << "Ar cik daudz kaulinus izmantosiet?" << endl;
        cin >> n;
        pile_size = n;
        current_player = 1;

        while (pile_size > 0) {
            cout << "Kaudze atrodas " << pile_size << " kaulinu." << endl;
            if (current_player == 1) {
                your_move();
            }
            else {
                computer_move();
            }
            current_player = -current_player;
        }
        cout << "Spele Beidzas!" << endl;
        if (current_player == 1) {
            cout << "Apsveicam ar uzvaru!" << endl;
        }
        else {
            cout << "Dators jus parvareja!" << endl;
        }

        char play_again;
        do {
            cout << "Spelesiet velreiz? (y/n) ";
            cin >> play_again;
        } while (play_again != 'y' && play_again != 'n');
        new_game = (play_again == 'y');
    }
    return 0;
}